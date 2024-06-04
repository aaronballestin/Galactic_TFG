using GalacticApi.Models;
using TeatroApi.Models;

namespace GalacticApi.Services
{
    public interface IUsuarioService
    {
        Usuario GetUserById(int id);

        UsuarioDTO AddUsuario(UsuarioPostDTO usuario);
        void AddUsuario(UsuarioIntranetPostDTO usuario);
        UsuarioEstadisticasDTO GetUsuarioEstadisticasDTO(int id);
        UsuarioDTO GetUsuario(string emailUsuario, string passwordUsuario);
        void UpdateUsuario(UsuarioIntranetPostDTO usuario, int id); 
        public List<GetUsuariosDTO> GetUsuariosDTOs();
        public void DeleteUsuario(int id);

    }
}