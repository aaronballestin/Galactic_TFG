using Microsoft.EntityFrameworkCore;
using GalacticApi.Models;
using Microsoft.Extensions.Logging;

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

        public Usuario GetUserById(int id)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Id == id);
        }
    }
}