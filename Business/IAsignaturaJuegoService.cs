using GalacticApi.Models;

namespace GalacticApi.Services
{
    public interface IAsignaturaJuegoService
    {
        GetAsignaturaJuegoDTO GetAsignaturaJuegoById(int id);
        List<GetAsignaturasJuegosDTO> GetAsignaturaJuegos();
        void DeleteAsignaturaJuego(int id);
        void AddAsignaturaJuego(AddAsignaturaJuegoDTO asignatura);
        void UpdateAsignaturaJuego(AsignaturaJuego asignatura);
    }
}