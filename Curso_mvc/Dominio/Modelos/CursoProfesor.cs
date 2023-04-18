using System;
using System.Collections.Generic;

namespace Curso_mvc.Dominio.Modelos;

public partial class CursoProfesor
{
    public int CursoProfesorId { get; set; }

    public int CursoId { get; set; }

    public int ProfesorId { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Curso Curso { get; set; } = null!;

    public virtual Profesor Profesor { get; set; } = null!;
}
