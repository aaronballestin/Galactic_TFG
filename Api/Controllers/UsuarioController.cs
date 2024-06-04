using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GalacticApi.Models;
using GalacticApi.Services;
using TeatroApi.Models;

namespace GalacticApi.Api
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;


        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }


        [HttpGet]
        public ActionResult<List<GetUsuariosDTO>> GetUsuarios()
        {
            try
            {
                var usuarios = _usuarioService.GetUsuariosDTOs();
                return Ok(usuarios);

            }
            catch (KeyNotFoundException ex)
            {
                return NotFound("No hay obras disponibles");
            }

        }

        [HttpGet("{id}")]
        public ActionResult<UsuarioEstadisticasDTO> GetUsuario(int id)
        {

            try
            {
                var usuario = _usuarioService.GetUsuarioEstadisticasDTO(id);
                return Ok(usuario);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound("No hay obra disponible con el id: " + id);
            }

        }

        [HttpPost]
        public ActionResult<UsuarioDTO> AddUsuario(UsuarioIntranetPostDTO usuarioPostDTO)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            try
            {
                
                _usuarioService.AddUsuario(usuarioPostDTO);
                return Ok(usuarioPostDTO);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }


        [HttpPost("/register")]
        public ActionResult<UsuarioDTO> AddUsuario(UsuarioPostDTO usuarioPostDTO)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            try
            {
                
                return _usuarioService.AddUsuario(usuarioPostDTO);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpPost("/login")]
        public ActionResult<UsuarioDTO> GetUsuario(UsuarioLoginDTO usuarioLoginDTO)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            try
            {

                return _usuarioService.GetUsuario(usuarioLoginDTO.email, usuarioLoginDTO.password);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }


        [HttpPut("{id}")]
        public ActionResult UpdateUsuario(int id, UsuarioIntranetPostDTO usuario)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            try
            {


                _usuarioService.UpdateUsuario(usuario, id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {

                return NotFound();
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUsuario(int id)
        {
            try
            {
                _usuarioService.DeleteUsuario(id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {

                return NotFound();
            }

        }
    }
}