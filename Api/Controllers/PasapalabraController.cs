using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GalacticApi.Models;
using GalacticApi.Services;

namespace GalacticApi.Api
{
    [ApiController]
    [Route("[controller]")]
    public class PasapalabraController : ControllerBase
    {
        private readonly IPasapalabraService _pasapalabraService;


        public PasapalabraController(IPasapalabraService pasapalabraService)
        {
            _pasapalabraService = pasapalabraService;
        }


        [HttpGet]
        public ActionResult<List<GetPasapalabrasDTO>> GetPasapalabras()
        {
            try
            {
                var pasaplabras = _pasapalabraService.GetPasapalabras();
                return Ok(pasaplabras);

            }
            catch (KeyNotFoundException ex)
            {
                return NotFound("No hay obras disponibles");
            }

        }

        [HttpGet("/multijugador")]
        public ActionResult<GetPasapalabraDTO> GetPasapalabrasMultijugador()
        {
            try
            {
                var pasaplabras = new List<GetPasapalabraDTO>();
                
                var pasapalabra1 = _pasapalabraService.GetPasapalabraMultijugador();
                pasapalabra1.Name = "Multijugador - 1";
                pasapalabra1.Id = 1;


                var pasapalabra2 =_pasapalabraService.GetPasapalabraMultijugador();
                pasapalabra2.Name = "Multijugador - 2";
                pasapalabra2.Id = 2;


                pasaplabras.Add(pasapalabra1);
                pasaplabras.Add(pasapalabra2);
                return Ok(pasaplabras);

            }
            catch (KeyNotFoundException ex)
            {
                return NotFound("No hay obras disponibles");
            }

        }



        [HttpGet("{id}")]
        public ActionResult<GetPasapalabraDTO> GetPasapalabra(int id)
        {
            
            try
            {
                var pasapalabra = _pasapalabraService.GetPasapalabraById(id);
                return Ok(pasapalabra);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound("No hay obra disponible con el id: " + id);
            }

        }


        [HttpPost]
        public ActionResult AddPasapalabra(Pasapalabra pasapalabra)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            try
            {
                _pasapalabraService.AddPasapalabra(pasapalabra);
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
                _pasapalabraService.DeletePasapalabra(id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {

                return NotFound();
            }

        }
    }
}