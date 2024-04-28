using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GalacticApi.Models;
using GalacticApi.Services;

namespace GalacticApi.Api
{
    [ApiController]
    [Route("[controller]")]
    public class PreguntaPasapalabraController : ControllerBase
    {
        private readonly IPreguntaPasapalabraService _pasapalabraService;


        public PreguntaPasapalabraController(IPreguntaPasapalabraService pasapalabraService)
        {
            _pasapalabraService = pasapalabraService;
        }


        [HttpGet]
        public ActionResult<List<GetPreguntasPasapalabraDTO>> GetPreguntaPasapalabras()
        {
            try
            {
                var pasaplabras = _pasapalabraService.GetPreguntasPasapalabra();
                return Ok(pasaplabras);

            }
            catch (KeyNotFoundException ex)
            {
                return NotFound("No hay obras disponibles");
            }

        }

        [HttpGet("{id}")]
        public ActionResult<GetPreguntaPasapalabraDTO> GetPasapalabra(int id)
        {
            
            try
            {
                var pasapalabra = _pasapalabraService.GetPreguntaPasapalabraById(id);
                return Ok(pasapalabra);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound("No hay obra disponible con el id: " + id);
            }

        }


        [HttpPost]
        public ActionResult AddPreguntaPasapalabra(PreguntaPasapalabra pasapalabra)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            try
            {
                _pasapalabraService.AddPreguntaPasapalabra(pasapalabra);
                return NoContent();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpPut("{id}")]
        public ActionResult UpdatePreguntaPasapalabra(int id, PreguntaPasapalabra pasapalabra)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            try
            {
                //Curso curso1 = _cursoService.GetCursoById(id);
                //if (id != curso1.Id)
                {
                    return BadRequest();
                }

                
                _pasapalabraService.UpdatePreguntaPasapalabra(pasapalabra);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {

                return NotFound();
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeletePreguntaPasapalabra(int id)
        {
            try
            {
                _pasapalabraService.DeletePreguntaPasapalabra(id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {

                return NotFound();
            }

        }
    }
}