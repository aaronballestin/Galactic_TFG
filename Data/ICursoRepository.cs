namespace GalacticApi.Models
{
    public interface ICursoRepository{
        Curso GetCursoById(int id);
        List<Curso> GetCursos();
        void DeleteCurso(Curso curso);
        void AddCurso(Curso curso);
        void UpdateCurso(Curso curso);

        
    }
}