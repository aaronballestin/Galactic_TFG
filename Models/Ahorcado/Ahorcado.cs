using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class Ahorcado{

        [Key]
        public int Id { get; set;}
        [Required]
        public string Name { get; set;}

        [ForeignKey("IdJuego")]
        public int IdJuego { get; set;}


        public Juego Juego{ get; set;}
        public PreguntaAhorcado PreguntaAhorcado {get; set;}

        public Ahorcado(){
            
        }
    }
}