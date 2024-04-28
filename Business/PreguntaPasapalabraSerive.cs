using GalacticApi.Data;
using GalacticApi.Models;

namespace GalacticApi.Services
{
    public class PreguntaPasapalabraService : IPreguntaPasapalabraService{
         private readonly IPreguntaPasapalabraRepository _preguntapasapalabraRepository;

    public PreguntaPasapalabraService(IPreguntaPasapalabraRepository pasapalabraRepository)
    {
        _preguntapasapalabraRepository = pasapalabraRepository;
    }

        public void AddPreguntaPasapalabra(PreguntaPasapalabra pasapalabra)
        {
            _preguntapasapalabraRepository.AddPreguntaPasapalabra(pasapalabra);
        }

        public void DeletePreguntaPasapalabra(int id)
        {
            PreguntaPasapalabra pasapalabra= _preguntapasapalabraRepository.GetPreguntaPasapalabraById(id);
            _preguntapasapalabraRepository.DeletePreguntaPasapalabra(pasapalabra);
        }

        public GetPreguntaPasapalabraDTO GetPreguntaPasapalabraById(int id)
        {
            var pasapalabra = _preguntapasapalabraRepository.GetPreguntaPasapalabraById(id);
            
            return new GetPreguntaPasapalabraDTO{Id = pasapalabra.Id, Letra = pasapalabra.Letra, Pregunta = pasapalabra.Pregunta, Respuesta = pasapalabra.Respuesta};


        }

        public List<GetPreguntasPasapalabraDTO> GetPreguntasPasapalabra()
        {
            return _preguntapasapalabraRepository.GetPreguntasPasapalabra().Select(c => new GetPreguntasPasapalabraDTO {Id = c.Id, Letra = c.Letra, Pregunta = c.Pregunta, Respuesta = c.Respuesta}).ToList();
        }

        public void UpdatePreguntaPasapalabra(PreguntaPasapalabra pasapalabra)
        {
            _preguntapasapalabraRepository.UpdatePreguntaPasapalabra(pasapalabra);
        }
    }
}