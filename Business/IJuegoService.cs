using GalacticApi.Models;

namespace GalacticApi.Services
{
    public interface IJuegoService{
        GetJuegoDTO GetJuegoById(int id);
        List<GetJuegosDTO> GetJuegos();
        void DeleteJuego(int id);
        void AddJuego(Juego juego);
        void UpdateJuego(Juego juego);
    }
}