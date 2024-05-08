using GalacticApi.Models;
using TeatroApi.Models;

namespace GalacticApi.Data
{
    public interface IUsuarioRepository{
        Usuario GetUserById(int id);
        
        void AddUsuario(Usuario usuario);
        Usuario GetUsuario(string emailUsuario, string passwordUsuario);
        // void UpdateUsuario(Usuario usuario); 

        // List<UsuarioDTO> GetUsuarios();

        void SaveChanges();
    }
}