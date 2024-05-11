using GalacticApi.Data;
using GalacticApi.Models;

namespace GalacticApi.Services
{
    public class TipoJuegoService : ITipoJuegoService
    {
        private readonly ITipoJuegoRepository _tipoJuegoRepository;

        public TipoJuegoService(ITipoJuegoRepository tipoJuegoRepository)
        {
            _tipoJuegoRepository = tipoJuegoRepository;
        }

        public void AddTipoJuego(TipoJuego curso)
        {
            _tipoJuegoRepository.AddTipoJuego(curso);
        }

        public void DeleteTipoJuego(int id)
        {
            TipoJuego tipoJuego = _tipoJuegoRepository.GetTipoJuegoById(id);
            _tipoJuegoRepository.DeleteTipoJuego(tipoJuego);
        }

        public GetTipoJuegoDTO GetTipoJuegoById(int id)
        {
            var juegoDTO = _tipoJuegoRepository.GetTipoJuegoById(id);
            var juegos = new List<GetJuegosDTO>();
            foreach (var juego in juegoDTO.Juegos)
            {
                var asignaturaDTO = new GetJuegosDTO { Id = juego.Id, TemaJuego = juego.TemaJuego };
                juegos.Add(asignaturaDTO);
            }
            return new GetTipoJuegoDTO { Id = juegoDTO.Id, Juegos = juegos, Tipo = juegoDTO.Tipo  };


        }

        public List<GetTipoJuegosDTO> GetTipoJuegos()
        {
            return _tipoJuegoRepository.GetTipoJuegos().Select(c => new GetTipoJuegosDTO { Id = c.Id, Tipo = c.Tipo }).ToList();
        }

        public void UpdateTipoJuego(TipoJuego tipoJuego)
        {
            _tipoJuegoRepository.UpdateTipoJuego(tipoJuego);
        }
    }
}