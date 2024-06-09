using GalacticApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GalacticApi.Models
{
    public class PreguntaPasapalabraRepository : IPreguntaPasapalabraRepository
    {
        private readonly GalacticApiContext _context;

        private readonly ILogger<PreguntaPasapalabraRepository> _logger;

        public PreguntaPasapalabraRepository(ILogger<PreguntaPasapalabraRepository> logger, GalacticApiContext context)
        {
            _context = context;
            _logger = logger;
        }

        public PreguntaPasapalabra GetPreguntaPasapalabraById(int id)
        {
            try
            {
                var pregunta = _context.PreguntaPasapalabras.FirstOrDefault(c => c.Id == id);
                return pregunta;
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }

        }
        public List<PreguntaPasapalabra> GetPreguntasPasapalabra()
        {
            try
            {
                return _context.PreguntaPasapalabras.ToList();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }
        }
        public void DeletePreguntaPasapalabra(PreguntaPasapalabra pasapalabra)
        {
            try
            {
                _context.PreguntaPasapalabras.Remove(pasapalabra);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }


        }
        public void AddPreguntaPasapalabra(PreguntaPasapalabra pasapalabra)
        {
            try
            {
                _context.PreguntaPasapalabras.Add(pasapalabra);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }


        }
        public void UpdatePreguntaPasapalabra(PreguntaPasapalabra pasapalabra)
        {
            try
            {
                _context.Entry(pasapalabra).State = EntityState.Modified;
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