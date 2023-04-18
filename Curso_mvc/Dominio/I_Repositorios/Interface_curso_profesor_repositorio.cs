using Curso_mvc.Models;
namespace Curso_mvc.Dominio.I_Repositorios
{
    public interface Interface_curso_profesor_repositorio
    {
        Task<List<Profesor_Datos>> ConsultaProgramas();
        Task<Profesor_Datos> CrearActualizarPrograma(Profesor_Datos modelo);
        Task<Profesor_Datos> EliminarPrograma(Profesor_Datos modelo);
        Task<Profesor_Datos> ConsultarPrograma(Profesor_Datos modelo);
    }
}
