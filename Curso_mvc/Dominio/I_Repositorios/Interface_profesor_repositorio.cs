using Microsoft.AspNetCore.Mvc.Rendering;
using Curso_mvc.Models;

namespace Curso_mvc.Dominio.I_Repositorios
{
    public interface Interface_profesor_repositorio
    {
        Task<List<Profesor_Datos>> ConsultaProfesores();
        Task<Respuesta> CrearActualizarProfesor(Profesor_Datos modelo);
        Task<Respuesta> EliminarProfesor(Profesor_Datos modelo);
        Task<Profesor_Datos> ConsultarProfesor(Profesor_Datos modelo);
        Task<List<SelectListItem>> ListaSeleccionProfesor();
    }
}
