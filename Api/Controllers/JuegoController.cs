using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GalacticApi.Models;
using GalacticApi.Services;

namespace GalacticApi.Api
{
    [ApiController]
    [Route("[controller]")]
    public class JuegoController : ControllerBase
    {
        private readonly IJuegoService _juegoService;


        public JuegoController(IJuegoService juegoService)
        {
            _juegoService = juegoService;
        }


        [HttpGet]
        public ActionResult<List<GetJuegosDTO>> GetJuegos()
        {
            try
            {
                var juegos = _juegoService.GetJuegos();
                return Ok(juegos);

            }
            catch (KeyNotFoundException ex)
            {
                return NotFound("No hay obras disponibles");
            }

        }

        [HttpGet("{id}")]
        public ActionResult<GetJuegoDTO> GetJuego(int id)
        {
            
            try
            {
                var juego = _juegoService.GetJuegoById(id);
                return Ok(juego);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound("No hay obra disponible con el id: " + id);
            }

        }


        [HttpPost]
        public ActionResult AddJuego(AddJuegoDTO juego)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            try
            {
                _juegoService.AddJuego(juego);
                return NoContent();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpPut("{id}")]
        public ActionResult UpdateJuego(int id, Juego juego)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            try
            {
                //Curso curso1 = _cursoService.GetCursoById(id);
                //if (id != curso1.Id)
                {
                    return BadRequest();
                }

                
                _juegoService.UpdateJuego(juego);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {

                return NotFound();
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteJuego(int id)
        {
            try
            {
                _juegoService.DeleteJuego(id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {

                return NotFound();
            }

        }
    }
}