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

        [ForeignKey("AvatarId")]
        public int AvatarId { get; set;}

        public Avatar avatar{ get; set;}
        public Usuario (){

        }
    }
}