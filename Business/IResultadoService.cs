using GalacticApi.Models;

namespace GalacticApi.Services
{
    public interface IResultadoService
    {
        public void AddResultado(GetPasapalabraDTO resultado, int id);
        public List<GetResultadosDTO> GetResultados();
        public List<int> GetResultadosCurso(int id);
        public List<int> GetResultadosAsignatura(int id);
        public List<GetResultadosProfesorDTO> GetResultadosProfesor(int id);
    }
}