using GalacticApi.Models;

namespace GalacticApi.Services
{
    public interface IAhorcadoService{
        AhorcadoDTO GetAhorcadoById(int id);
        List<AhorcadosDTO> GetAhorcados();
        void DeleteAhorcado(int id);
        void AddAhorcado(Ahorcado pasapalabra);
    }
}