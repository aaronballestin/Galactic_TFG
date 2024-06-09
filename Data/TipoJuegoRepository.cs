using GalacticApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GalacticApi.Models
{
    public class TipoJuegoRepository : ITipoJuegoRepository
    {
        private readonly GalacticApiContext _context;

        private readonly ILogger<TipoJuegoRepository> _logger;

        public TipoJuegoRepository(ILogger<TipoJuegoRepository> logger, GalacticApiContext context)
        {
            _context = context;
            _logger = logger;
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
        public List<TipoJuego> GetTipoJuegos()
        {
            try
            {
                return _context.TipoJuegos.ToList();

            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }
        }
        public void DeleteTipoJuego(TipoJuego tipoJuego)
        {
            try
            {
                _context.TipoJuegos.Remove(tipoJuego);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
            }


        }
        public void AddTipoJuego(TipoJuego tipoJuego)
        {
            try
            {
                _context.TipoJuegos.Add(tipoJuego);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
            }


        }
        public void UpdateTipoJuego(TipoJuego tipoJuego)
        {
            try
            {
                _context.Entry(tipoJuego).State = EntityState.Modified;
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