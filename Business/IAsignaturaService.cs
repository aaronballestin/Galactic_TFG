using GalacticApi.Models;

namespace GalacticApi.Services
{
    public interface IAsignaturaService
    {
        Asignatura GetAsignaturaById(int id);
        List<Asignatura> GetAsignaturas();
        void DeleteAsignatura(int id);
        void AddAsignatura(Asignatura asignatura);
        void UpdateAsignatura(Asignatura asignatura);
    }
}