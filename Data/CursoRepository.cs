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
            try
            {
                var curso = _context.Cursos.FirstOrDefault(c => c.CursoId == id);
                curso.Juegos = _context.Juegos.Where(a => a.IdCurso == curso.CursoId).ToList();
                return curso;
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }

        }
        public List<Curso> GetCursos()
        {
            try
            {
                return _context.Cursos.ToList();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }
        }
        public void DeleteCurso(Curso curso)
        {
            try
            {
                _context.Cursos.Remove(curso);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
            }


        }
        public void AddCurso(Curso curso)
        {
            try
            {
                _context.Cursos.Add(curso);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
            }


        }
        public void UpdateCurso(Curso curso)
        {
            try
            {
                _context.Entry(curso).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }


        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}