using GalacticApi.Models;
using TeatroApi.Models;

namespace GalacticApi.Services
{
    public interface IUsuarioService
    {
        Usuario GetUserById(int id);

        UsuarioDTO AddUsuario(UsuarioPostDTO usuario);
        UsuarioDTO GetUsuario(string emailUsuario, string passwordUsuario);
        // void UpdateUsuario(Usuario usuario); 

        // List<UsuarioDTO> GetUsuarios();

    }
}