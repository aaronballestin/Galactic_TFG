using GalacticApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GalacticApi.Models
{
    public class CursoRepository : ICursoRepository
    {
        private readonly GalacticApiContext _context;

        private readonly ILogger<CursoRepository> _logger;

        public CursoRepository(ILogger<CursoRepository> logger, GalacticApiContext context)
        {
            _context = context;
            _logger = logger;
        }

        public Curso GetCursoById(int id)
        {
            var curso = _context.Cursos.FirstOrDefault(c => c.CursoId == id);
            curso.Juegos = _context.Juegos.Where(a => a.IdCurso== curso.CursoId).ToList();
            return curso;
        }
        public List<Curso> GetCursos()
        {
            return _context.Cursos.ToList();
        }
        public void DeleteCurso(Curso curso)
        {
            _context.Cursos.Remove(curso);
            _context.SaveChanges();

        }
        public void AddCurso(Curso curso)
        {
            _context.Cursos.Add(curso);
            _context.SaveChanges();

        }
        public void UpdateCurso(Curso curso)
        {
            _context.Entry(curso).State = EntityState.Modified;
            _context.SaveChanges();

        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}