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
            var asignaturaJuego = new List<GetAsignaturasJuegosDTO>();
            foreach (var a in asignatura.AsignaturaJuegos)
            {
                var asignaturaJuegoDTO = new GetAsignaturasJuegosDTO  {Id = a.Id, JuegoAsignatura = a.JuegoAsignatura};
                asignaturaJuego.Add(asignaturaJuegoDTO);
            }
            return new GetAsignaturaDTO {Id = asignatura.Id, NombreAsignatura = asignatura.NombreAsignatura, AsignaturasJuegos = asignaturaJuego};

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