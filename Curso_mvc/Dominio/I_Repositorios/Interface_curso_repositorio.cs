using Microsoft.AspNetCore.Mvc.Rendering;
using Curso_mvc.Models;

namespace Curso_mvc.Dominio.I_Repositorios
{
    public interface Interface_curso_repositorio
    {
        Task<List<Curso_Datos>> ConsultaCursos();
        Task<Respuesta> CrearActualizarCurso(Curso_Datos modelo);
        Task<Respuesta> EliminarCurso(Curso_Datos modelo);
        Task<Curso_Datos> ConsultarCurso(Curso_Datos modelo);
        Task<List<SelectListItem>> ListaSeleccionCursos();
    }
}
