using System;
using System.Collections.Generic;

namespace Curso_mvc.Dominio.Modelos;

public partial class Profesor
{
    public int ProfesorId { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public virtual ICollection<CursoProfesor> CursoProfesors { get; } = new List<CursoProfesor>();
}
