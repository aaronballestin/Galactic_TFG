using GalacticApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GalacticApi.Models
{
    public class ResultadoRepository : IResultadoRepository
    {
        private readonly GalacticApiContext _context;

        private readonly ILogger<ResultadoRepository> _logger;

        public ResultadoRepository(ILogger<ResultadoRepository> logger, GalacticApiContext context)
        {
            _context = context;
            _logger = logger;
        }

        public List<Resultados> GetResultados()
        {
            try
            {

            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
            }
            return _context.Resultados.ToList();
        }

        public List<GetResultadosProfesorDTO> GetResultadosProfesor(int id)
        {
            try
            {
                var resultados = GetResultadosByClase(id);
                var resultadosDTO = new List<GetResultadosProfesorDTO>();
                foreach (var item in resultados)
                {
                    string Usuario = _context.Usuarios.FirstOrDefault(u => u.Id == item.IdUsuario).Name;
                    string Juego = _context.Juegos.FirstOrDefault(u => u.Id == item.IdJuego).TemaJuego;
                    var resultadoDTO = new GetResultadosProfesorDTO { Juego = Juego, Usuario = Usuario, Acertadas = item.Acertadas, Falladas = item.Falladas, Resultado = item.Resultado };
                    resultadosDTO.Add(resultadoDTO);
                }
                return resultadosDTO;
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }

        }

        public List<Resultados> GetResultadosByClase(int id)
        {
            try
            {
                var resultadosFiltro = new List<Resultados>();
                var resultados = _context.Resultados.ToList();

                foreach (var item in resultados)
                {
                    if (id == _context.Usuarios.FirstOrDefault(c => c.Id == item.IdUsuario).ClaseId)
                    {
                        resultadosFiltro.Add(item);
                    }
                }
                return resultadosFiltro;
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }

        }

        public void AddResultado(Resultados resultado)
        {
            try
            {
                _context.Resultados.Add(resultado);
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
            }

        }

        public List<GetResultadosAsignaturaDTO> GetResultadosAsignatura(int id)
        {
            try
            {
                var resultadosFiltro = GetResultadosByClase(id);
                var resultados = resultadosFiltro.Select(x => new GetResultadosAsignaturaDTO { IdJuego = x.IdJuego, Completado = x.Completado, Resultado = x.Resultado }).ToList();
                foreach (var i in resultados)
                {
                    i.IdAsignatura = _context.Juegos.FirstOrDefault(a => a.Id == i.IdJuego).IdAsignatura;
                }

                return resultados;
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }

        }

        public List<GetResultadosCursoDTO> GetResultadosCurso(int id)
        {
            try
            {
                var resultadosFiltro = GetResultadosByClase(id);
                var resultados = resultadosFiltro.Select(x => new GetResultadosCursoDTO { IdJuego = x.IdJuego, Completado = x.Completado, Resultado = x.Resultado }).ToList();
                foreach (var i in resultados)
                {
                    i.IdCurso = _context.Juegos.FirstOrDefault(a => a.Id == i.IdJuego).IdCurso;
                }

                return resultados;
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }

        }



        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}