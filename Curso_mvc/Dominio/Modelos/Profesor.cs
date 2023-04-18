using System;
using System.Collections.Generic;

namespace Curso_mvc.Dominio.Modelos;

public partial class Profesor
{
    public int ProfesorId { get; set; }
    //=null significa que acepta valores nulos
    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    //aquí va la relación entre curso_profesor y profesor
    //basecamente es una tupla
    public virtual ICollection<CursoProfesor> CursoProfesors { get; } = new List<CursoProfesor>();
}
