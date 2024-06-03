using GalacticApi.Data;
using GalacticApi.Models;
using GalacticApi.Models;

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
            var usuario = new Usuario {Name =  usuarioDTO.nombre, Email = usuarioDTO.email, Password=usuarioDTO.password, AvatarId= 1, Rol= "Alumno"};
            _usuarioRepository.AddUsuario(usuario);
            return GetUsuario(usuarioDTO.email, usuarioDTO.password);
        }

        public void AddUsuario(UsuarioIntranetPostDTO usuarioDTO){
            var usuario = new Usuario {Name =  usuarioDTO.name, Email = usuarioDTO.email, Password=usuarioDTO.password, AvatarId= 1, Rol= usuarioDTO.rol};
            _usuarioRepository.AddUsuario(usuario);
        }

        public void UpdateUsuario(UsuarioIntranetPostDTO usuarioDTO, int id){
            var usuario = _usuarioRepository.GetUserById(id);
            usuario.Rol = usuarioDTO.rol;
            usuario.Name = usuarioDTO.name;
            usuario.Email = usuarioDTO.email;
            _usuarioRepository.UpdateUsuario(usuario);
        }


        public Usuario GetUserById(int id)
        {
            return _usuarioRepository.GetUserById(id);
        }

        public UsuarioDTO GetUsuario(string emailUsuario, string passwordUsuario)
        {
            var usuario = _usuarioRepository.GetUsuario(emailUsuario,passwordUsuario);
            var usuarioDTO = new UsuarioDTO {id = usuario.Id, email = usuario.Email, nombre = usuario.Name, avatar = "textoejemplo", rol = usuario.Rol};
            return usuarioDTO;
        }

        public List<GetUsuariosDTO> GetUsuariosDTOs(){
            return _usuarioRepository.GetUsuarios().Select(u => new GetUsuariosDTO{Id = u.Id, Email = u.Email, Name = u.Name, Rol = u.Rol}).ToList();
        }

        public void DeleteUsuario(int id){
            Usuario user = _usuarioRepository.GetUserById(id);
            _usuarioRepository.DeleteUsuario(user);
        }
    }
}