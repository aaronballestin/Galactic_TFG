using GalacticApi.Data;
using GalacticApi.Models;

namespace GalacticApi.Services
{
    public class AsignaturaService : IAsignaturaService{
         private readonly IAsignaturaRepository _asignaturaRepository;

    public AsignaturaService(IAsignaturaRepository asignaturaRepository)
    {
        _asignaturaRepository = asignaturaRepository;
    }

        public void AddAsignatura(Asignatura asignatura)
        {
            _asignaturaRepository.AddAsignatura(asignatura);
        }

        public void DeleteAsignatura(int id)
        {
            Asignatura asignatura = _asignaturaRepository.GetAsignaturaById(id);
            _asignaturaRepository.DeleteAsignatura(asignatura);
        }

        public GetAsignaturaDTO GetAsignaturaById(int id)
        {
            var asignatura = _asignaturaRepository.GetAsignaturaById(id);
            var juegos = new List<GetJuegosDTO>();
            foreach (var a in asignatura.Juegos)
            {
                var asignaturaJuegoDTO = new GetJuegosDTO  {Id = a.Id, TemaJuego = a.TemaJuego};
                juegos.Add(asignaturaJuegoDTO);
            }
            return new GetAsignaturaDTO {Id = asignatura.Id, NombreAsignatura = asignatura.NombreAsignatura, Juegos = juegos};

        }

        public List<GetAsignaturasDTO> GetAsignaturas()
        {
            return _asignaturaRepository.GetAsignaturas().Select(s => new GetAsignaturasDTO {Id = s.Id, NombreAsignatura = s.NombreAsignatura}).ToList();
        }

        public void UpdateAsignatura(Asignatura asignatura)
        {
            _asignaturaRepository.UpdateAsignatura(asignatura);
        }
    }
}