using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class GetUsuariosDTO{
        public int Id { get; set;}
        public string Name { get; set;}
        public string Email { get; set;}
        public string Rol { get; set;}

        public GetUsuariosDTO (){

        }
    }
}