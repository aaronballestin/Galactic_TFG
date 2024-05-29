namespace GalacticApi.Models
{
    public interface IResultadoRepository{
        public void AddResultado(Resultados resultado);
        public List<Resultados> GetResultados();
        public List<GetResultadosAsignaturaDTO> GetResultadosAsignatura();
        public List<GetResultadosCursoDTO> GetResultadosCurso();
    }
}