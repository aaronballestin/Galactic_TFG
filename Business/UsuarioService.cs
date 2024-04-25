using GalacticApi.Data;
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

        public Usuario GetUserById(int id)
        {
            return _usuarioRepository.GetUserById(id);
        }
    }
}