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
            var pregunta = _context.PreguntaPasapalabras.FirstOrDefault(c => c.Id == id);
            return pregunta;
        }
        public List<PreguntaPasapalabra> GetPreguntasPasapalabra()
        {
            return _context.PreguntaPasapalabras.ToList();
        }
        public void DeletePreguntaPasapalabra(PreguntaPasapalabra pasapalabra)
        {
            _context.PreguntaPasapalabras.Remove(pasapalabra);
            _context.SaveChanges();

        }
        public void AddPreguntaPasapalabra(PreguntaPasapalabra pasapalabra)
        {
            _context.PreguntaPasapalabras.Add(pasapalabra);
            _context.SaveChanges();

        }
        public void UpdatePreguntaPasapalabra(PreguntaPasapalabra pasapalabra)
        {
            _context.Entry(pasapalabra).State = EntityState.Modified;
            _context.SaveChanges();

        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}