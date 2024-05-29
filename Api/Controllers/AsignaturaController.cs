using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GalacticApi.Models;
using GalacticApi.Services;

namespace GalacticApi.Api
{
    [ApiController]
    [Route("[controller]")]
    public class AsignaturaController : ControllerBase
    {
        private readonly IAsignaturaService _asignaturaService;


        public AsignaturaController(IAsignaturaService asignaturaService)
        {
            _asignaturaService = asignaturaService;
        }


        [HttpGet]
        public ActionResult<List<GetAsignaturasDTO>> GetAsignaturas()
        {
            try
            {
                var asignaturas = _asignaturaService.GetAsignaturas();
                return Ok(asignaturas);

            }
            catch (KeyNotFoundException ex)
            {
                return NotFound("No hay obras disponibles");
            }

        }

        [HttpGet("{id}")]
        public ActionResult<GetAsignaturaDTO> GetAsignatura(int id)
        {
            
            try
            {
                var asignatura = _asignaturaService.GetAsignaturaById(id);
                return Ok(asignatura);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound("No hay obra disponible con el id: " + id);
            }

        }


        [HttpPost]
        public ActionResult AddAsignatura(PostAsignaturasDTO asignatura)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            try
            {
                _asignaturaService.AddAsignatura(asignatura);
                return NoContent();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpPut("{id}")]
        public ActionResult UpdateAsignatura(int id, PostAsignaturasDTO asignatura)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            try
            {
                
                _asignaturaService.UpdateAsignatura(asignatura,id);
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
                _asignaturaService.DeleteAsignatura(id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {

                return NotFound();
            }

        }
    }
}