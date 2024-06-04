using GalacticApi.Models;

namespace GalacticApi.Data
{
    public interface IAhorcadoRepository
    {
        Ahorcado GetAhorcadoById(int id);
        List<Ahorcado> GetAhorcados();
        void DeleteAhorcado(Ahorcado pasapalabra);
        void AddAhorcado(Ahorcado pasapalabra);
        void UpdateAhorcado(Ahorcado pasapalabra);
    }
}