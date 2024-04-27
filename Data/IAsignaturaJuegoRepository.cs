using GalacticApi.Models;

namespace GalacticApi.Data
{
    public interface IAsignaturaJuegoRepository
    {
        AsignaturaJuego GetAsignaturaJuegoById(int id);
        List<AsignaturaJuego> GetAsignaturaJuegos();
        void DeleteAsignaturaJuego(AsignaturaJuego asignatura);
        void AddAsignaturaJuego(AsignaturaJuego asignatura);
        void UpdateAsignaturaJuego(AsignaturaJuego asignatura);
    }
}