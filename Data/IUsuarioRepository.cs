using GalacticApi.Models;
using GalacticApi.Models;

namespace GalacticApi.Data
{
    public interface IUsuarioRepository{
        Usuario GetUserById(int id);
        
        void AddUsuario(Usuario usuario);
        Usuario GetUsuario(string emailUsuario, string passwordUsuario);
        void UpdateUsuario(Usuario usuario); 
        List<Usuario> GetUsuarios();

        public void DeleteUsuario(Usuario usuario);
        public Usuario UsuarioEstadisticas(int id);
        string NombreJuego(int id);
        void SaveChanges();
    }
}