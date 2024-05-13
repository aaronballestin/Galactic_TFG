using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GalacticApi.Models;
using GalacticApi.Services;

namespace GalacticApi.Api
{
    [ApiController]
    [Route("[controller]")]
    public class BuscadorController : ControllerBase
    {
        private readonly IBuscadorService _buscadorService;


        public BuscadorController(IBuscadorService buscadorService)
        {
            _buscadorService = buscadorService;
        }


        // [HttpGet]
        // public ActionResult<List<GetAsignaturasDTO>> GetAsignaturas()
        // {
        //     try
        //     {
        //         var asignaturas = _asignaturaService.GetAsignaturas();
        //         return Ok(asignaturas);

        //     }
        //     catch (KeyNotFoundException ex)
        //     {
        //         return NotFound("No hay obras disponibles");
        //     }

        // }


        [HttpPost]
        public ActionResult<List<BuscadorJuegosDTO>> BusquedaFormulario(BuscadorFormulario buscadorFormulario )
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            try
            {
                return _buscadorService.BuscadorFormulario(buscadorFormulario.IdCurso, buscadorFormulario.IdAsignatura, buscadorFormulario.IdTipoJuego);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }



    }
}