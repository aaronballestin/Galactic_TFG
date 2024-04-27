using GalacticApi.Data;
using GalacticApi.Models;

namespace GalacticApi.Services
{
    public class JuegoService : IJuegoService{
         private readonly IJuegoRepository _juegoRepository;

    public JuegoService(IJuegoRepository juegoRepository)
    {
        _juegoRepository = juegoRepository;
    }

        public void AddJuego(Juego juego)
        {
            _juegoRepository.AddJuego(juego);
        }

        public void DeleteJuego(int id)
        {
            Juego juego= _juegoRepository.GetJuegoById(id);
            _juegoRepository.DeleteJuego(juego);
        }

        public GetJuegoDTO GetJuegoById(int id)
        {
            var juego = _juegoRepository.GetJuegoById(id);
            
            return new GetJuegoDTO{Id = juego.Id, Codigo = juego.Codigo, TemaJuego = juego.TemaJuego};


        }

        public List<GetJuegosDTO> GetJuegos()
        {
            return _juegoRepository.GetJuegos().Select(c => new GetJuegosDTO {Id = c.Id, Codigo = c.Codigo, TemaJuego = c.TemaJuego}).ToList();
        }

        public void UpdateJuego(Juego juego)
        {
            _juegoRepository.UpdateJuego(juego);
        }
    }
}