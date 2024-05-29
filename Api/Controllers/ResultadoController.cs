using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GalacticApi.Models;
using GalacticApi.Services;

namespace GalacticApi.Api
{
    [ApiController]
    [Route("[controller]")]
    public class ResultadoController : ControllerBase
    {
        private readonly IResultadoService _resultadoService;


        public ResultadoController(IResultadoService resultadoService)
        {
            _resultadoService = resultadoService;
        }

        [HttpGet]
        public ActionResult<List<GetResultadosDTO>> GetResultados(){
            try
            {
                return _resultadoService.GetResultados();
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        [HttpGet("asignaturas")]
        public ActionResult<List<int>> GetResultadosAsignaturas(){
            try
            {
                return _resultadoService.GetResultadosAsignatura();
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        [HttpGet("cursos")]
        public ActionResult<List<int>> GetResultadosCursos(){
            try
            {
                return _resultadoService.GetResultadosCurso();
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        [HttpPost]
        public ActionResult AddResultado(GetPasapalabraDTO pasapalabraDTO, int id){
            try
            {
                _resultadoService.AddResultado(pasapalabraDTO, id);
                return NoContent();
                
            }
            catch (System.Exception)
            {
                return BadRequest();
                throw;
            }
 
        }

    }
}