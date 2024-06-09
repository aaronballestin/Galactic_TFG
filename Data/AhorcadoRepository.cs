using System.IO.Compression;
using GalacticApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GalacticApi.Models
{
    public class AhorcadoRepository : IAhorcadoRepository
    {
        private readonly GalacticApiContext _context;

        private readonly ILogger<AhorcadoRepository> _logger;

        public AhorcadoRepository(ILogger<AhorcadoRepository> logger, GalacticApiContext context)
        {
            _context = context;
            _logger = logger;
        }

        public Ahorcado GetAhorcadoById(int id)
        {
            try
            {
                var ahorcado = _context.Ahorcados.FirstOrDefault(c => c.Id == id);
                ahorcado.PreguntaAhorcado = _context.PreguntaAhorcados.FirstOrDefault(a => a.AhorcadoId == id);
                return ahorcado;
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }

        }

        // public GetPasapalabraDTO GetPasapalabraMultijugador()
        // {
        //     GetPasapalabraDTO pasapalabraDTO = new GetPasapalabraDTO();
        //     List<GetPreguntasPasapalabraDTO> preguntas = new List<GetPreguntasPasapalabraDTO>();
        //     var letra = 'A';
        //     for (int i = 0; i < 26; i++)
        //     {
        //         var pregunta = _context.PreguntaPasapalabras.Where(i => i.Letra == letra).OrderBy(x => Guid.NewGuid()).Take(1).ToList().Select(p=> new GetPreguntasPasapalabraDTO{Id = p.Id, Pregunta = p.Pregunta, Letra = p.Letra, Respuesta = p.Respuesta, acertado = false, contestado= false }).FirstOrDefault();
        //         preguntas.Add(pregunta);
        //         letra++;
        //     }
        //     pasapalabraDTO.Preguntas = preguntas;

        //     return pasapalabraDTO;

        // }


        public List<Ahorcado> GetAhorcados()
        {
            try
            {
                return _context.Ahorcados.ToList();

            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }
        }
        public void DeleteAhorcado(Ahorcado ahorcado)
        {
            try
            {
                _context.Ahorcados.Remove(ahorcado);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");

            }


        }
        public void AddAhorcado(Ahorcado ahorcado)
        {
            try
            {
                _context.Ahorcados.Add(ahorcado);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
            }


        }
        public void UpdateAhorcado(Ahorcado ahorcado)
        {
            try
            {
                _context.Entry(ahorcado).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
            }


        }



        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}