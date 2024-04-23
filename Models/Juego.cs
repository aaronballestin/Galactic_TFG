using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class Juego{
        [Key]
        public int Id { get; set;}
        [Required]
        public string TemaJuego { get; set;}
        [Required]
        public string Codigo { get; set;}
        [ForeignKey("AsignaturaJuego")]
        public int AsignaturaJuego { get; set;}

        public AsignaturaJuego asignaturaJuego{ get; set;}

        public Juego(){

        }
    }
}