using GalacticApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GalacticApi.Data
{
    public class AsignaturaJuegoRepository : IAsignaturaJuegoRepository{
        private readonly GalacticApiContext _context;

        private readonly ILogger<AsignaturaRepository> _logger;

        public AsignaturaJuegoRepository(ILogger<AsignaturaRepository> logger, GalacticApiContext context)
        {
            _context = context;
            _logger = logger;
        }

        public AsignaturaJuego GetAsignaturaJuegoById(int id)
        {
            var asignatura = _context.AsignaturaJuegos.FirstOrDefault(c => c.Id == id);
            asignatura.Juegos = _context.Juegos.Where(c => c.IdAsignaturaJuego == asignatura.Id).ToList();
            return asignatura;
        }
        public List<AsignaturaJuego> GetAsignaturaJuegos()
        {
            return _context.AsignaturaJuegos.ToList();
        }
        public void DeleteAsignaturaJuego(AsignaturaJuego asignatura)
        {
            _context.AsignaturaJuegos.Remove(asignatura);
            _context.SaveChanges();

        }
        public void AddAsignaturaJuego(AsignaturaJuego asignatura)
        {
            _context.AsignaturaJuegos.Add(asignatura);
            _context.SaveChanges();

        }
        public void UpdateAsignaturaJuego(AsignaturaJuego asignatura)
        {
            _context.Entry(asignatura).State = EntityState.Modified;
            _context.SaveChanges();

        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}