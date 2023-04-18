using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Curso_mvc.Dominio.Modelos;

public partial class CursoContext : DbContext
{
    public CursoContext()
    {
    }

    public CursoContext(DbContextOptions<CursoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<CursoProfesor> CursoProfesors { get; set; }

    public virtual DbSet<Profesor> Profesors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("TrustServerCertificate=True;Server= DESKTOP-GK24MHA;Database=curso;user id=sa; password=juan1513; MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Curso>(entity =>
        {
            entity.ToTable("Curso");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CursoProfesor>(entity =>
        {
            entity.ToTable("CursoProfesor");

            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

            entity.HasOne(d => d.Curso).WithMany(p => p.CursoProfesors)
                .HasForeignKey(d => d.CursoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CursoProfesor_Curso");

            entity.HasOne(d => d.Profesor).WithMany(p => p.CursoProfesors)
                .HasForeignKey(d => d.ProfesorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CursoProfesor_Profesor");
        });

        modelBuilder.Entity<Profesor>(entity =>
        {
            entity.ToTable("Profesor");

            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
