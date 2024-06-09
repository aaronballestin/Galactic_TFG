using GalacticApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GalacticApi.Data
{
    public class BuscadorRepository : IBuscadorRepository
    {
        private readonly GalacticApiContext _context;

        private readonly ILogger<BuscadorRepository> _logger;

        public BuscadorRepository(ILogger<BuscadorRepository> logger, GalacticApiContext context)
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

        public Asignatura GetAsignaturaById(int id)
        {
            try
            {
                var asignatura = _context.Asignaturas.FirstOrDefault(c => c.Id == id);
                asignatura.Juegos = _context.Juegos.Where(c => c.IdAsignatura == asignatura.Id).ToList();
                return asignatura;
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }

        }

        public TipoJuego GetTipoJuegoById(int id)
        {
            try
            {
                var juego = _context.TipoJuegos.FirstOrDefault(c => c.Id == id);
                juego.Juegos = _context.Juegos.Where(a => a.IdCurso == juego.Id).ToList();
                return juego;
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }

        }

        public List<Juego> GetJuegos()
        {
            try
            {
                return _context.Juegos.ToList();

            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }
        }


    }
}