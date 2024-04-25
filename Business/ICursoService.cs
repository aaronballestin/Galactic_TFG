using GalacticApi.Models;

namespace GalacticApi.Services
{
    public interface ICursoService{
        GetCurso GetCursoById(int id);
        List<GetCursos> GetCursos();
        void DeleteCurso(int id);
        void AddCurso(Curso curso);
        void UpdateCurso(Curso curso);
    }
}