using GalacticApi.Models;

namespace GalacticApi.Services
{
    public interface ITipoJuegoService{
        GetTipoJuegoDTO GetTipoJuegoById(int id);
        List<GetTipoJuegosDTO> GetTipoJuegos();
        void DeleteTipoJuego(int id);
        void AddTipoJuego(TipoJuego tipoJuego);
        void UpdateTipoJuego(TipoJuego tipoJuego);
    }
}