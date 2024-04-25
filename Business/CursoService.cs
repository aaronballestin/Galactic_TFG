using GalacticApi.Data;
using GalacticApi.Models;

namespace GalacticApi.Services
{
    public class CursoService : ICursoService{
         private readonly ICursoRepository _cursoRepository;

    public CursoService(ICursoRepository cursoRepository)
    {
        _cursoRepository = cursoRepository;
    }

        public void AddCurso(Curso curso)
        {
            _cursoRepository.AddCurso(curso);
        }

        public void DeleteCurso(int id)
        {
            Curso curso= _cursoRepository.GetCursoById(id);
            _cursoRepository.DeleteCurso(curso);
        }

        public Curso GetCursoById(int id)
        {
            return _cursoRepository.GetCursoById(id);
        }

        public List<GetCursos> GetCursos()
        {
            return _cursoRepository.GetCursos().Select(c => new GetCursos {Id = c.Id, NombreCurso =c.NombreCurso}).ToList();
        }

        public void UpdateCurso(Curso curso)
        {
            _cursoRepository.UpdateCurso(curso);
        }
    }
}