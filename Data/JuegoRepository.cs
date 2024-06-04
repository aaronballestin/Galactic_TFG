using GalacticApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GalacticApi.Models
{
    public class JuegoRepository : IJuegoRepository
    {
        private readonly GalacticApiContext _context;


        public JuegoRepository(GalacticApiContext context)
        {
            _context = context;
        }

        public Juego GetJuegoById(int id)
        {
            var juego = _context.Juegos.FirstOrDefault(c => c.Id == id);
            return juego;
        }
        public List<Juego> GetJuegos()
        {
            return _context.Juegos.ToList();
        }
        public void DeleteJuego(Juego juego)
        {
            _context.Juegos.Remove(juego);
            _context.SaveChanges();

        }
        public void AddJuego(Juego juego)
        {
            _context.Juegos.Add(juego);
            _context.SaveChanges();

        }
        public void UpdateJuego(Juego juego)
        {
            _context.Entry(juego).State = EntityState.Modified;
            _context.SaveChanges();

        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}