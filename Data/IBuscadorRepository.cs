using GalacticApi.Models;

namespace GalacticApi.Data
{
    public interface IBuscadorRepository
    {
        Curso GetCursoById(int id);
        Asignatura GetAsignaturaById(int id);
        TipoJuego GetTipoJuegoById(int id);
        List<Juego> GetJuegos();
    }
}