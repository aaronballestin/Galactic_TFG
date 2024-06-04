using GalacticApi.Models;

namespace GalacticApi.Services
{
    public interface IPasapalabraService{
        GetPasapalabraDTO GetPasapalabraById(int id);
        List<GetPasapalabrasDTO> GetPasapalabras();
        void DeletePasapalabra(int id);
        void AddPasapalabra(Pasapalabra pasapalabra);
        void UpdatePasapalabra(Pasapalabra pasapalabra);
        public GetPasapalabraDTO GetPasapalabraMultijugador();
    }
}