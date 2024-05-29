using GalacticApi.Models;

namespace GalacticApi.Services
{
    public interface ICursoService{
        GetCursoDTO GetCursoById(int id);
        List<GetCursosDTO> GetCursos();
        void DeleteCurso(int id);
        void AddCurso(PostCursosDTO curso);
        void UpdateCurso(Curso curso);
    }
}