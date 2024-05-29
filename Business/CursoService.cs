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

        public void AddCurso(PostCursosDTO cursoDTO)
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
            var juegos = new List<GetJuegosDTO>();
            foreach (var juego in curso.Juegos)
            {
                var asignaturaDTO = new GetJuegosDTO{Id = juego.Id, TemaJuego = juego.TemaJuego};
                juegos.Add(asignaturaDTO);
            }
            return new GetCursoDTO{Id =curso.CursoId, NombreCurso = curso.NombreCurso, Juegos=juegos};


        }

        public List<GetCursosDTO> GetCursos()
        {
            return _cursoRepository.GetCursos().Select(c => new GetCursosDTO {Id = c.CursoId, NombreCurso =c.NombreCurso}).ToList();
        }

        public void UpdateCurso(PostCursosDTO cursoDTO, int id)
        {
            var curso = _cursoRepository.GetCursoById(id);
            if (curso != null){
                curso.NombreCurso = cursoDTO.NombreCurso;
                _cursoRepository.UpdateCurso(curso);
            }

        }
    }
}