using GalacticApi.Models;

namespace GalacticApi.Services
{
    public interface IUsuarioService{
        Usuario GetUserById(int id);
    }
}