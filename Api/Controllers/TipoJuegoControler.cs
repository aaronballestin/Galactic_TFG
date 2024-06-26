using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GalacticApi.Models;
using GalacticApi.Services;

namespace GalacticApi.Api
{
    [ApiController]
    [Route("[controller]")]
    public class TipoJuegoController : ControllerBase
    {
        private readonly ITipoJuegoService _tipoJuegoService;


        public TipoJuegoController(ITipoJuegoService tipoJuegoService)
        {
            _tipoJuegoService = tipoJuegoService;
        }


        [HttpGet]
        public ActionResult<List<GetTipoJuegosDTO>> GetTipoJuegos()
        {
            try
            {
                var cursos = _tipoJuegoService.GetTipoJuegos();
                return Ok(cursos);

            }
            catch (KeyNotFoundException ex)
            {
                return NotFound("No hay obras disponibles");
            }

        }

        [HttpGet("{id}")]
        public ActionResult<GetTipoJuegoDTO> GetCurso(int id)
        {
            
            try
            {
                var curso = _tipoJuegoService.GetTipoJuegoById(id);
                return Ok(curso);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound("No hay obra disponible con el id: " + id);
            }

        }


        [HttpPost]
        public ActionResult AddTipoJuego(PostTipoJuegosDTO tipoJuegosDTO)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            try
            {
                _tipoJuegoService.AddTipoJuego(tipoJuegosDTO);
                return NoContent();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpPut("{id}")]
        public ActionResult UpdateTipoJuego(int id, PostTipoJuegosDTO tipoJuego)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            try
            {

                
                _tipoJuegoService.UpdateTipoJuego(tipoJuego,id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {

                return NotFound();
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTipoJuego(int id)
        {
            try
            {
                _tipoJuegoService.DeleteTipoJuego(id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {

                return NotFound();
            }

        }
    }
}