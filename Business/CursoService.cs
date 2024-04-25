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

        public GetCurso GetCursoById(int id)
        {
            var curso = _cursoRepository.GetCursoById(id);
            var asignaturas = new List<AsignaturaCursoDTO>();
            foreach (var asignatura in curso.Asignaturas)
            {
                var asignaturaDTO = new AsignaturaCursoDTO{Id = asignatura.Id, NombreAsignatura = asignatura.NombreAsignatura};
                asignaturas.Add(asignaturaDTO);
            }
            return new GetCurso{Id =curso.CursoId, Asignaturas=asignaturas, NombreCurso = curso.NombreCurso};


        }

        public List<GetCursos> GetCursos()
        {
            return _cursoRepository.GetCursos().Select(c => new GetCursos {Id = c.CursoId, NombreCurso =c.NombreCurso}).ToList();
        }

        public void UpdateCurso(Curso curso)
        {
            _cursoRepository.UpdateCurso(curso);
        }
    }
}