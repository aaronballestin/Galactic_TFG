using GalacticApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GalacticApi.Data
{
    public class AsignaturaRepository : IAsignaturaRepository
    {
        private readonly GalacticApiContext _context;

        private readonly ILogger<AsignaturaRepository> _logger;

        public AsignaturaRepository(ILogger<AsignaturaRepository> logger, GalacticApiContext context)
        {
            _context = context;
            _logger = logger;
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
        public List<Asignatura> GetAsignaturas()
        {
            try
            {
                return _context.Asignaturas.ToList();

            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }
        }
        public void DeleteAsignatura(Asignatura asignatura)
        {
            try
            {
                _context.Asignaturas.Remove(asignatura);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
            }


        }
        public void AddAsignatura(Asignatura asignatura)
        {
            try
            {
                _context.Asignaturas.Add(asignatura);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
            }


        }
        public void UpdateAsignatura(Asignatura asignatura)
        {
            try
            {
                _context.Entry(asignatura).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
            }


        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}