using GalacticApi.Models;

namespace GalacticApi.Services
{
    public interface IBuscadorService{

        List<BuscadorJuegosDTO> BuscadorFormulario(int curso, int asignatura, int tipoJuego);
    }
}