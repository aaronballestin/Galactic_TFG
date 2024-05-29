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

        public List<Resultados> GetResultados(){
            return _context.Resultados.ToList();
        }

        public void AddResultado(Resultados resultado){
            _context.Resultados.Add(resultado);
            SaveChanges();
        }

        public List<GetResultadosAsignaturaDTO> GetResultadosAsignatura(){
           var resultados =  _context.Resultados.Select(x => new GetResultadosAsignaturaDTO{IdJuego = x.IdJuego, Completado = x.Completado, Resultado = x.Resultado}).ToList();
            foreach (var i in resultados)
            {
                i.IdAsignatura = _context.Juegos.FirstOrDefault(a => a.Id == i.IdJuego).IdAsignatura;
            }

           return resultados;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}