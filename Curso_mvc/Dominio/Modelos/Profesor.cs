using System;
using System.Collections.Generic;

namespace Curso_mvc.Dominio.Modelos;

public partial class Profesor
{
    public int ProfesorId { get; set; }
<<<<<<< HEAD
    //=null significa que acepta valores nulos
=======

>>>>>>> 160e0c95eb7004e64ccc7b254be34ca4410137fa
    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

<<<<<<< HEAD
    //aquí va la relación entre curso_profesor y profesor
    //basecamente es una tupla
=======
>>>>>>> 160e0c95eb7004e64ccc7b254be34ca4410137fa
    public virtual ICollection<CursoProfesor> CursoProfesors { get; } = new List<CursoProfesor>();
}
