using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GalacticApi.Models;
using GalacticApi.Services;

namespace GalacticApi.Api
{
    [ApiController]
    [Route("[controller]")]
    public class CursoController : ControllerBase
    {
        private readonly ICursoService _cursoService;


        public CursoController(ICursoService cursoService)
        {
            _cursoService = cursoService;
        }


        [HttpGet]
        public ActionResult<List<GetCursos>> GetCursos()
        {
            try
            {
                var cursos = _cursoService.GetCursos();
                return Ok(cursos);

            }
            catch (KeyNotFoundException ex)
            {
                return NotFound("No hay obras disponibles");
            }

        }

        [HttpGet("{id}")]
        public ActionResult<GetCurso> GetObra(int id)
        {
            
            try
            {
                var curso = _cursoService.GetCursoById(id);
                return Ok(curso);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound("No hay obra disponible con el id: " + id);
            }

        }


        [HttpPost]
        public ActionResult AddCurso(Curso curso)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            try
            {
                _cursoService.AddCurso(curso);
                return NoContent();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpPut("{id}")]
        public ActionResult UpdateObra(int id, Curso curso)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            try
            {
                //Curso curso1 = _cursoService.GetCursoById(id);
                //if (id != curso1.Id)
                {
                    return BadRequest();
                }

                
                _cursoService.UpdateCurso(curso);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {

                return NotFound();
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteObra(int id)
        {
            try
            {
                _cursoService.DeleteCurso(id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {

                return NotFound();
            }

        }
    }
}