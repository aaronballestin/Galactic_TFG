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

        public List<Resultados> GetResultadosByClase(int id){
            var resultadosFiltro = new List<Resultados>();
            var resultados = _context.Resultados.ToList();

            foreach (var item in resultados)
            {
                if (id == _context.Usuarios.FirstOrDefault(c => c.Id == item.IdUsuario).ClaseId){
                    resultadosFiltro.Add(item);
                }
            }
            return resultadosFiltro;
        }

        public void AddResultado(Resultados resultado){
            _context.Resultados.Add(resultado);
            SaveChanges();
        }

        public List<GetResultadosAsignaturaDTO> GetResultadosAsignatura(int id){
            var resultadosFiltro = GetResultadosByClase(id);
            var resultados =  resultadosFiltro.Select(x => new GetResultadosAsignaturaDTO{IdJuego = x.IdJuego, Completado = x.Completado, Resultado = x.Resultado}).ToList();
            foreach (var i in resultados)
            {
                i.IdAsignatura = _context.Juegos.FirstOrDefault(a => a.Id == i.IdJuego).IdAsignatura;
            }

           return resultados;
        }

        public List<GetResultadosCursoDTO> GetResultadosCurso(int id){
            var resultadosFiltro = GetResultadosByClase(id);
            var resultados =  resultadosFiltro.Select(x => new GetResultadosCursoDTO{IdJuego = x.IdJuego, Completado = x.Completado, Resultado = x.Resultado}).ToList();
            foreach (var i in resultados)
            {
                i.IdCurso = _context.Juegos.FirstOrDefault(a => a.Id == i.IdJuego).IdCurso;
            }

           return resultados;
        }

        

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}