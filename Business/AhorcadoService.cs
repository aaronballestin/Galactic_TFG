using GalacticApi.Data;
using GalacticApi.Models;

namespace GalacticApi.Services
{
    public class AhorcadoService : IAhorcadoService{
         private readonly IAhorcadoRepository _ahorcadoRepository;

    public AhorcadoService(IAhorcadoRepository ahorcadoRepository)
    {
        _ahorcadoRepository = ahorcadoRepository;
    }

        public void AddAhorcado(Ahorcado pasapalabra)
        {
            _ahorcadoRepository.AddAhorcado(pasapalabra);
        }

        public void DeleteAhorcado(int id)
        {
            Ahorcado pasapalabra= _ahorcadoRepository.GetAhorcadoById(id);
            _ahorcadoRepository.DeleteAhorcado(pasapalabra);
        }

        public AhorcadoDTO GetAhorcadoById(int id)
        {
            var ahorcado = _ahorcadoRepository.GetAhorcadoById(id);
            var pregunta = new PreguntaAhorcadoDTO {Id = ahorcado.PreguntaAhorcado.Id, Pregunta = ahorcado.PreguntaAhorcado.Pregunta, Respuesta = ahorcado.PreguntaAhorcado.Respuesta};
            return new AhorcadoDTO{Id = ahorcado.Id, Name = ahorcado.Name, PreguntaAhorcado = pregunta};
        }

        public List<AhorcadosDTO> GetAhorcados()
        {
            return _ahorcadoRepository.GetAhorcados().Select(c => new AhorcadosDTO {Id = c.Id, Name = c.Name}).ToList();
        }

        // public void UpdateAhorcado(Ahorcado pasapalabra)
        // {
        //     _ahorcadoRepository.UpdateAhorcado(pasapalabra);
        // }

    }
}