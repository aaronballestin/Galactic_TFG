using GalacticApi.Data;
using GalacticApi.Models;
using TeatroApi.Models;

namespace GalacticApi.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public UsuarioDTO AddUsuario(UsuarioPostDTO usuarioDTO)
        {
            var usuario = new Usuario {Name =  usuarioDTO.nombre, Email = usuarioDTO.email, Password=usuarioDTO.password, AvatarId= 1};
            _usuarioRepository.AddUsuario(usuario);
            return GetUsuario(usuarioDTO.email, usuarioDTO.password);
        }

        public Usuario GetUserById(int id)
        {
            return _usuarioRepository.GetUserById(id);
        }

        public UsuarioDTO GetUsuario(string emailUsuario, string passwordUsuario)
        {
            var usuario = _usuarioRepository.GetUsuario(emailUsuario,passwordUsuario);
            var usuarioDTO = new UsuarioDTO {id = usuario.Id, email = usuario.Email, nombre = usuario.Name, avatar = "textoejemplo"};
            return usuarioDTO;
        }
    }
}