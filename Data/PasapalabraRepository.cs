using GalacticApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GalacticApi.Models
{
    public class PasapalabraRepository : IPasapalabraRepository
    {
        private readonly GalacticApiContext _context;

        private readonly ILogger<PasapalabraRepository> _logger;

        public PasapalabraRepository(ILogger<PasapalabraRepository> logger, GalacticApiContext context)
        {
            _context = context;
            _logger = logger;
        }

        public Pasapalabra GetPasapalabraById(int id)
        {
            var pasapalabra = _context.Pasapalabras.FirstOrDefault(c => c.Id == id);
            pasapalabra.PreguntaPasapalabras= _context.PreguntaPasapalabras.Where(a => a.PasapalabraId== pasapalabra.Id).ToList();
            return pasapalabra;
        }

        public GetPasapalabraDTO GetPasapalabraMultijugador()
        {
            GetPasapalabraDTO pasapalabraDTO = new GetPasapalabraDTO();
            List<GetPreguntasPasapalabraDTO> preguntas = new List<GetPreguntasPasapalabraDTO>();
            var letra = 'A';
            for (int i = 0; i < 27; i++)
            {
                letra++;
                var pregunta = _context.PreguntaPasapalabras.Where(i => i.Letra == letra).OrderBy(x => Guid.NewGuid()).Take(1).ToList().Select(p=> new GetPreguntasPasapalabraDTO{Id = p.Id, Pregunta = p.Pregunta, Letra = p.Letra, Respuesta = p.Respuesta, acertado = false, contestado= false }).FirstOrDefault();
                preguntas.Add(pregunta);
            }
            pasapalabraDTO.Preguntas = preguntas;

            return pasapalabraDTO;
            
        }


        public List<Pasapalabra> GetPasapalabras()
        {
            return _context.Pasapalabras.ToList();
        }
        public void DeletePasapalabra(Pasapalabra pasapalabra)
        {
            _context.Pasapalabras.Remove(pasapalabra);
            _context.SaveChanges();

        }
        public void AddPasapalabra(Pasapalabra pasapalabra)
        {
            _context.Pasapalabras.Add(pasapalabra);
            _context.SaveChanges();

        }
        public void UpdatePasapalabra(Pasapalabra pasapalabra)
        {
            _context.Entry(pasapalabra).State = EntityState.Modified;
            _context.SaveChanges();

        }



        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}