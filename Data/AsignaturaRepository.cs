using GalacticApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GalacticApi.Data
{
    public class AsignaturaRepository : IAsignaturaRepository{
        private readonly GalacticApiContext _context;

        private readonly ILogger<AsignaturaRepository> _logger;

        public AsignaturaRepository(ILogger<AsignaturaRepository> logger, GalacticApiContext context)
        {
            _context = context;
            _logger = logger;
        }

        public Asignatura GetAsignaturaById(int id)
        {
            var asignatura = _context.Asignaturas.FirstOrDefault(c => c.Id == id);
            asignatura.AsignaturaJuegos = _context.AsignaturaJuegos.Where(c => c.IdAsignatura == asignatura.Id).ToList();
            return asignatura;
        }
        public List<Asignatura> GetAsignaturas()
        {
            return _context.Asignaturas.ToList();
        }
        public void DeleteAsignatura(Asignatura asignatura)
        {
            _context.Asignaturas.Remove(asignatura);
            _context.SaveChanges();

        }
        public void AddAsignatura(Asignatura asignatura)
        {
            _context.Asignaturas.Add(asignatura);
            _context.SaveChanges();

        }
        public void UpdateAsignatura(Asignatura asignatura)
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