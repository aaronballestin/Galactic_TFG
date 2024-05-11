namespace GalacticApi.Models
{
    public interface ITipoJuegoRepository{
        TipoJuego GetTipoJuegoById(int id);
        List<TipoJuego> GetTipoJuegos();
        void DeleteTipoJuego(TipoJuego tipoJuego);
        void AddTipoJuego(TipoJuego tipoJuego);
        void UpdateTipoJuego(TipoJuego tipoJuego);

        
    }
}