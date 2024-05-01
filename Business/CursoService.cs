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

        public void AddCurso(AddCursoDTO cursoDTO)
        {
            var curso = new Curso {NombreCurso = cursoDTO.NombreCurso};
            _cursoRepository.AddCurso(curso);
        }

        public void DeleteCurso(int id)
        {
            Curso curso= _cursoRepository.GetCursoById(id);
            _cursoRepository.DeleteCurso(curso);
        }

        public GetCursoDTO GetCursoById(int id)
        {
            var curso = _cursoRepository.GetCursoById(id);
            var asignaturas = new List<GetAsignaturasDTO>();
            foreach (var asignatura in curso.Asignaturas)
            {
                var asignaturaDTO = new GetAsignaturasDTO{Id = asignatura.Id, NombreAsignatura = asignatura.NombreAsignatura};
                asignaturas.Add(asignaturaDTO);
            }
            return new GetCursoDTO{Id =curso.CursoId, Asignaturas=asignaturas, NombreCurso = curso.NombreCurso};


        }

        public List<GetCursosDTO> GetCursos()
        {
            return _cursoRepository.GetCursos().Select(c => new GetCursosDTO {Id = c.CursoId, NombreCurso =c.NombreCurso}).ToList();
        }

        public void UpdateCurso(Curso curso)
        {
            _cursoRepository.UpdateCurso(curso);
        }
    }
}