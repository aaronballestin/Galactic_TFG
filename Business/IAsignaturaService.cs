using GalacticApi.Models;

namespace GalacticApi.Services
{
    public interface IAsignaturaService
    {
        GetAsignaturaDTO GetAsignaturaById(int id);
        List<GetAsignaturasDTO> GetAsignaturas();
        void DeleteAsignatura(int id);
        void AddAsignatura(PostAsignaturasDTO asignatura);
        void UpdateAsignatura(Asignatura asignatura);
    }
}