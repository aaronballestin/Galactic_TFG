using GalacticApi.Data;
using GalacticApi.Models;

namespace GalacticApi.Services
{
    public class BuscadorService : IBuscadorService
    {
        private readonly IBuscadorRepository _buscadorRepository;

        public BuscadorService(IBuscadorRepository buscadorRepository)
        {
            _buscadorRepository = buscadorRepository;
        }

        public List<BuscadorJuegosDTO> BuscadorFormulario(int cursoId, int asignaturaId, int tipoJuegoId)
        {
            var buscadorJuegos = new List<BuscadorJuegosDTO>();
            var juegos = _buscadorRepository.GetJuegos();

            if (cursoId > 0)
            {
                juegos.RemoveAll(item => item.IdCurso != cursoId);
            }

            if (asignaturaId > 0)
            {
                juegos.RemoveAll(item => item.IdAsignatura != asignaturaId);
            }

            if (tipoJuegoId > 0)
            {
                juegos.RemoveAll(item => item.IdTipoJuego != tipoJuegoId);
            }

            buscadorJuegos = juegos.Select(juego => new BuscadorJuegosDTO { Id = juego.Id, Codigo = juego.Codigo, TemaJuego = juego.TemaJuego, IdCurso = juego.IdCurso, IdAsignatura = juego.IdAsignatura, IdTipoJuego = juego.IdTipoJuego }).ToList();

            return buscadorJuegos;

        }
    }
}