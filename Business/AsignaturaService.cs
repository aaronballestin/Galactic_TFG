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

        public Asignatura GetAsignaturaById(int id)
        {
            return _asignaturaRepository.GetAsignaturaById(id);

        }

        public List<Asignatura> GetAsignaturas()
        {
            return _asignaturaRepository.GetAsignaturas();
        }

        public void UpdateAsignatura(Asignatura asignatura)
        {
            _asignaturaRepository.UpdateAsignatura(asignatura);
        }
    }
}