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
            var juego = _context.TipoJuegos.FirstOrDefault(c => c.Id == id);
            juego.Juegos = _context.Juegos.Where(a => a.IdCurso== juego.Id).ToList();
            return juego;
        }
        public List<TipoJuego> GetTipoJuegos()
        {
            return _context.TipoJuegos.ToList();
        }
        public void DeleteTipoJuego(TipoJuego tipoJuego)
        {
            _context.TipoJuegos.Remove(tipoJuego);
            _context.SaveChanges();

        }
        public void AddTipoJuego(TipoJuego tipoJuego)
        {
            _context.TipoJuegos.Add(tipoJuego);
            _context.SaveChanges();

        }
        public void UpdateTipoJuego(TipoJuego tipoJuego)
        {
            _context.Entry(tipoJuego).State = EntityState.Modified;
            _context.SaveChanges();

        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}