using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GalacticApi.Models;
using GalacticApi.Services;

namespace GalacticApi.Api
{
    [ApiController]
    [Route("[controller]")]
    public class AhorcadoController : ControllerBase
    {
        private readonly IAhorcadoService _ahorcadoService;


        public AhorcadoController(IAhorcadoService ahorcadoService)
        {
            _ahorcadoService = ahorcadoService;
        }


        [HttpGet]
        public ActionResult<List<AhorcadosDTO>> GetPasapalabras()
        {
            try
            {
                var pasaplabras = _ahorcadoService.GetAhorcados();
                return Ok(pasaplabras);

            }
            catch (KeyNotFoundException ex)
            {
                return NotFound("No hay obras disponibles");
            }

        }





        [HttpGet("{id}")]
        public ActionResult<AhorcadoDTO> GetAhorcado(int id)
        {
            
            try
            {
                var pasapalabra = _ahorcadoService.GetAhorcadoById(id);
                return Ok(pasapalabra);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound("No hay obra disponible con el id: " + id);
            }

        }


        [HttpPost]
        public ActionResult AddAhorcado(Ahorcado pasapalabra)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            try
            {
                _ahorcadoService.AddAhorcado(pasapalabra);
                return NoContent();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        // [HttpPut("{id}")]
        // public ActionResult UpdatePasapalabra(int id, Pasapalabra pasapalabra)
        // {
        //     if (!ModelState.IsValid) { return BadRequest(ModelState); }
        //     try
        //     {
                
        //         _pasapalabraService.UpdatePasapalabra(pasapalabra);
        //         return NoContent();
        //     }
        //     catch (KeyNotFoundException ex)
        //     {

        //         return NotFound();
        //     }

        // }

        [HttpDelete("{id}")]
        public IActionResult DeletePasapalabra(int id)
        {
            try
            {
                _ahorcadoService.DeleteAhorcado(id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {

                return NotFound();
            }

        }
    }
}