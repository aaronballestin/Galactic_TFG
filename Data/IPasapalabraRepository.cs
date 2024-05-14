using GalacticApi.Models;

namespace GalacticApi.Data
{
    public interface IPasapalabraRepository
    {
        Pasapalabra GetPasapalabraById(int id);
        List<Pasapalabra> GetPasapalabras();
        void DeletePasapalabra(Pasapalabra pasapalabra);
        void AddPasapalabra(PostPasapalabraDTO pasapalabra);
        void UpdatePasapalabra(Pasapalabra pasapalabra);
    }
}