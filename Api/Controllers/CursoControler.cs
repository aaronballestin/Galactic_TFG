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
        public ActionResult<List<GetCursosDTO>> GetCursos()
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
        public ActionResult<GetCursoDTO> GetCurso(int id)
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
        public ActionResult AddCurso(PostCursosDTO curso)
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
        public ActionResult UpdateCurso(int id, PostCursosDTO curso)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            try
            {
                _cursoService.UpdateCurso(curso, id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {

                return NotFound();
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCurso(int id)
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