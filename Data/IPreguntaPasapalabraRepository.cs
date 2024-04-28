using GalacticApi.Models;

namespace GalacticApi.Data
{
    public interface IPreguntaPasapalabraRepository
    {
        PreguntaPasapalabra GetPreguntaPasapalabraById(int id);
        List<PreguntaPasapalabra> GetPreguntasPasapalabra();
        void DeletePreguntaPasapalabra(PreguntaPasapalabra pasapalabra);
        void AddPreguntaPasapalabra(PreguntaPasapalabra pasapalabra);
        void UpdatePreguntaPasapalabra(PreguntaPasapalabra pasapalabra);
    }
}