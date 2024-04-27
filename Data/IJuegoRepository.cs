namespace GalacticApi.Models
{
    public interface IJuegoRepository{
        Juego GetJuegoById(int id);
        List<Juego> GetJuegos();
        void DeleteJuego(Juego juego);
        void AddJuego(Juego juego);
        void UpdateJuego(Juego juego);

        
    }
}