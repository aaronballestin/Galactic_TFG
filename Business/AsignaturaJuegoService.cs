using GalacticApi.Data;
using GalacticApi.Models;

namespace GalacticApi.Services
{
    public class AsignaturaJuegoService : IAsignaturaJuegoService{
         private readonly IAsignaturaJuegoRepository _asignaturaRepository;

    public AsignaturaJuegoService(IAsignaturaJuegoRepository asignaturaRepository)
    {
        _asignaturaRepository = asignaturaRepository;
    }

        public void AddAsignaturaJuego(AsignaturaJuego asignatura)
        {
            _asignaturaRepository.AddAsignaturaJuego(asignatura);
        }

        public void DeleteAsignaturaJuego(int id)
        {
            AsignaturaJuego asignatura = _asignaturaRepository.GetAsignaturaJuegoById(id);
            _asignaturaRepository.DeleteAsignaturaJuego(asignatura);
        }

        public GetAsignaturaJuegoDTO GetAsignaturaJuegoById(int id)
        {
            var asignatura = _asignaturaRepository.GetAsignaturaJuegoById(id);
            var juegos = new List<GetJuegosDTO>();
            foreach (var a in asignatura.Juegos)
            {
                var juegosDTO = new GetJuegosDTO  {Id = a.Id, Codigo = a.Codigo, TemaJuego = a.TemaJuego};
                juegos.Add(juegosDTO);
            }
            return new GetAsignaturaJuegoDTO {Id = asignatura.Id, JuegoAsignatura = asignatura.JuegoAsignatura, Juegos = juegos};

        }

        public List<GetAsignaturasJuegosDTO> GetAsignaturaJuegos()
        {
            return _asignaturaRepository.GetAsignaturaJuegos().Select(s => new GetAsignaturasJuegosDTO {Id = s.Id, JuegoAsignatura = s.JuegoAsignatura}).ToList();
        }

        public void UpdateAsignaturaJuego(AsignaturaJuego asignatura)
        {
            _asignaturaRepository.UpdateAsignaturaJuego(asignatura);
        }
    }
}