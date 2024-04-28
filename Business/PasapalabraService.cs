using GalacticApi.Data;
using GalacticApi.Models;

namespace GalacticApi.Services
{
    public class PasapalabraService : IPasapalabraService{
         private readonly IPasapalabraRepository _pasapalabraRepository;

    public PasapalabraService(IPasapalabraRepository pasapalabraRepository)
    {
        _pasapalabraRepository = pasapalabraRepository;
    }

        public void AddPasapalabra(Pasapalabra pasapalabra)
        {
            _pasapalabraRepository.AddPasapalabra(pasapalabra);
        }

        public void DeletePasapalabra(int id)
        {
            Pasapalabra pasapalabra= _pasapalabraRepository.GetPasapalabraById(id);
            _pasapalabraRepository.DeletePasapalabra(pasapalabra);
        }

        public GetPasapalabraDTO GetPasapalabraById(int id)
        {
            var pasapalabra = _pasapalabraRepository.GetPasapalabraById(id);
            List<GetPreguntasPasapalabraDTO> preguntas = new List<GetPreguntasPasapalabraDTO>();
            foreach (var i in pasapalabra.PreguntaPasapalabras)
            {
                var pregunta = new GetPreguntasPasapalabraDTO {Id = i.Id, Letra = i.Letra, Pregunta = i.Pregunta, Respuesta = i.Respuesta};
                preguntas.Add(pregunta);
            }

            return new GetPasapalabraDTO{Id = pasapalabra.Id, Name = pasapalabra.Name, Preguntas = preguntas};


        }

        public List<GetPasapalabrasDTO> GetPasapalabras()
        {
            return _pasapalabraRepository.GetPasapalabras().Select(c => new GetPasapalabrasDTO {Id = c.Id, Name = c.Name}).ToList();
        }

        public void UpdatePasapalabra(Pasapalabra pasapalabra)
        {
            _pasapalabraRepository.UpdatePasapalabra(pasapalabra);
        }
    }
}