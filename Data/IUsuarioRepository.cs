using GalacticApi.Models;

namespace GalacticApi.Data
{
    public interface IUsuarioRepository{
        Usuario GetUserById(int id);
        
        
    }
}