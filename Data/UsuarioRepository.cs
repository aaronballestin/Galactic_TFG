using Microsoft.EntityFrameworkCore;
using GalacticApi.Models;
using Microsoft.Extensions.Logging;
using GalacticApi.Models;

namespace GalacticApi.Data
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly GalacticApiContext _context;

        private readonly ILogger<UsuarioRepository> _logger;

        public UsuarioRepository(ILogger<UsuarioRepository> logger, GalacticApiContext context)
        {
            _context = context;
            _logger = logger;
        }

        public void AddUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

        }

        public Usuario GetUserById(int id)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Id == id);
        }

        public Usuario GetUsuario(string emailUsuario, string passwordUsuario)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Email == emailUsuario && u.Password == passwordUsuario);

        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}