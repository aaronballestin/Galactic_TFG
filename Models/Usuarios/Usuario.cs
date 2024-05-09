using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class Usuario{
        [Key]
        public int Id { get; set;}
        [Required]
        public string Name { get; set;}
        [Required]
        public string Email { get; set;}
        [Required]
        public string Password { get; set;}

        [Required]
        public string Rol { get; set;}

        [ForeignKey("AvatarId")]
        public int AvatarId { get; set;}

        public List<Resultados> Resultados{ get; set;}
        public Avatar Avatar{ get; set;}
        public Usuario (){

        }
    }
}