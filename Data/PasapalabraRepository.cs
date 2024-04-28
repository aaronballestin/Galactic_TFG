using GalacticApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GalacticApi.Models
{
    public class PasapalabraRepository : IPasapalabraRepository
    {
        private readonly GalacticApiContext _context;

        private readonly ILogger<PasapalabraRepository> _logger;

        public PasapalabraRepository(ILogger<PasapalabraRepository> logger, GalacticApiContext context)
        {
            _context = context;
            _logger = logger;
        }

        public Pasapalabra GetPasapalabraById(int id)
        {
            var pasapalabra = _context.Pasapalabras.FirstOrDefault(c => c.Id == id);
            pasapalabra.PreguntaPasapalabras= _context.PreguntaPasapalabras.Where(a => a.IdPasapalabra== pasapalabra.Id).ToList();
            return pasapalabra;
        }
        public List<Pasapalabra> GetPasapalabras()
        {
            return _context.Pasapalabras.ToList();
        }
        public void DeletePasapalabra(Pasapalabra pasapalabra)
        {
            _context.Pasapalabras.Remove(pasapalabra);
            _context.SaveChanges();

        }
        public void AddPasapalabra(Pasapalabra pasapalabra)
        {
            _context.Pasapalabras.Add(pasapalabra);
            _context.SaveChanges();

        }
        public void UpdatePasapalabra(Pasapalabra pasapalabra)
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