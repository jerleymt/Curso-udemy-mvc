using System;
using System.Collections.Generic;

namespace Curso_mvc.Dominio.Modelos;

public partial class Curso
{
    public int CursoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<CursoProfesor> CursoProfesors { get; } = new List<CursoProfesor>();
}
