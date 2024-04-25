using GalacticApi.Models;

namespace GalacticApi.Data
{
    public interface IAsignaturaRepository
    {
        Asignatura GetAsignaturaById(int id);
        List<Asignatura> GetAsignaturas();
        void DeleteAsignatura(Asignatura curso);
        void AddAsignatura(Asignatura asignatura);
        void UpdateAsignatura(Asignatura asignatura);
    }
}