using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GalacticApi.Models;
using GalacticApi.Services;

namespace GalacticApi.Api
{
    [ApiController]
    [Route("[controller]")]
    public class AsignaturaJuegoController : ControllerBase
    {
        private readonly IAsignaturaJuegoService _asignaturaService;


        public AsignaturaJuegoController(IAsignaturaJuegoService asignaturaService)
        {
            _asignaturaService = asignaturaService;
        }


        [HttpGet]
        public ActionResult<List<GetAsignaturasJuegosDTO>> GetCursos()
        {
            try
            {
                var asignaturas = _asignaturaService.GetAsignaturaJuegos();
                return Ok(asignaturas);

            }
            catch (KeyNotFoundException ex)
            {
                return NotFound("No hay obras disponibles");
            }

        }

        [HttpGet("{id}")]
        public ActionResult<GetAsignaturaJuegoDTO> GetObra(int id)
        {
            
            try
            {
                var asignatura = _asignaturaService.GetAsignaturaJuegoById(id);
                return Ok(asignatura);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound("No hay obra disponible con el id: " + id);
            }

        }


        [HttpPost]
        public ActionResult AddAsignaturaJuego(AddAsignaturaJuegoDTO asignatura)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            try
            {
                _asignaturaService.AddAsignaturaJuego(asignatura);
                return NoContent();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpPut("{id}")]
        public ActionResult UpdateAsignaturaJuego(int id, AsignaturaJuego asignatura)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            try
            {
                //Curso curso1 = _cursoService.GetCursoById(id);
                //if (id != curso1.Id)
                {
                    return BadRequest();
                }

                
                _asignaturaService.UpdateAsignaturaJuego(asignatura);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {

                return NotFound();
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAsignatura(int id)
        {
            try
            {
                _asignaturaService.DeleteAsignaturaJuego(id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {

                return NotFound();
            }

        }
    }
}