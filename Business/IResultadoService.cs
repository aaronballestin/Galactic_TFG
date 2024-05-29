using GalacticApi.Models;

namespace GalacticApi.Services
{
    public interface IResultadoService
    {
        public void AddResultado(GetPasapalabraDTO resultado, int id);
        public List<GetResultadosDTO> GetResultados();
        public List<int> GetResultadosCurso();
        public List<int> GetResultadosAsignatura();
    }
}