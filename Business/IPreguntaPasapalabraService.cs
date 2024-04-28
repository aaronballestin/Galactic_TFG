using GalacticApi.Models;

namespace GalacticApi.Services
{
    public interface IPreguntaPasapalabraService{
        GetPreguntaPasapalabraDTO GetPreguntaPasapalabraById(int id);
        List<GetPreguntasPasapalabraDTO> GetPreguntasPasapalabra();
        void DeletePreguntaPasapalabra(int id);
        void AddPreguntaPasapalabra(PreguntaPasapalabra preguntaPasapalabra);
        void UpdatePreguntaPasapalabra(PreguntaPasapalabra preguntaPasapalabra);
    }
}