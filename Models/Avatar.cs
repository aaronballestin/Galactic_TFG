using System.ComponentModel.DataAnnotations;

namespace GalacticApi.Models
{
    public class Avatar{
        [Key]
        public int Id { get; set; }
        [Required]
        public string RutaFoto { get; set; }
        [Required]
        public char Premium { get; set; }
        [Required]
        public int CodigoJuego {get; set; }//este de aquí tiene que ver con el codigo del juego donde se consigue

        public List<Usuario> usuarios{ get; set; }

        public Avatar(){

        }
    }
}