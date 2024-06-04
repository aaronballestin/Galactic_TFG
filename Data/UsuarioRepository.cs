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

        public void UpdateUsuario(Usuario usuario){
            _context.Entry(usuario).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteUsuario(Usuario usuario){
            _context.Usuarios.Remove(usuario);
            SaveChanges();
        }

        public Usuario UsuarioEstadisticas(int id){
           var usuario =  _context.Usuarios.FirstOrDefault(u => u.Id == id);
            usuario.Resultados = _context.Resultados.Where(u => u.IdUsuario == id).ToList();
            return usuario;
        }



        public List<Usuario> GetUsuarios(){
            return _context.Usuarios.ToList();
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
            _context.SaveChanges();
        }
    }
}