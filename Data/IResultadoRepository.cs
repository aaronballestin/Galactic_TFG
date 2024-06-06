namespace GalacticApi.Models
{
    public interface IResultadoRepository{
        public void AddResultado(Resultados resultado);
        public List<Resultados> GetResultados();
        public List<GetResultadosAsignaturaDTO> GetResultadosAsignatura(int id);
        public List<GetResultadosCursoDTO> GetResultadosCurso(int id);
        public List<Resultados> GetResultadosByClase(int id);
    }
}