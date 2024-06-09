using GalacticApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GalacticApi.Models
{
    public class JuegoRepository : IJuegoRepository
    {
        private readonly GalacticApiContext _context;
        private readonly ILogger<JuegoRepository> _logger;


        public JuegoRepository(ILogger<JuegoRepository> logger, GalacticApiContext context)
        {
            _context = context;
            _logger = logger;
        }

        public Juego GetJuegoById(int id)
        {
            try
            {
                var juego = _context.Juegos.FirstOrDefault(c => c.Id == id);
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
        public void DeleteJuego(Juego juego)
        {
            try
            {
                _context.Juegos.Remove(juego);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
            }


        }
        public void AddJuego(Juego juego)
        {
            try
            {
                _context.Juegos.Add(juego);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
            }


        }
        public void UpdateJuego(Juego juego)
        {
            try
            {
                _context.Entry(juego).State = EntityState.Modified;
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