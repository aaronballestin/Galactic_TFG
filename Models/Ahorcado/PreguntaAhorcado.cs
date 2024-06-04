using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class PreguntaAhorcado{
        [Key]
        public int Id { get; set; } 
        [Required]
        public string Pregunta { get; set;} 
        [Required]
        public string Respuesta { get; set; }
        [Required]

        public int AhorcadoId { get; set; }    

        public Ahorcado Ahorcado{ get; set; }

        public PreguntaAhorcado(){

        }
    }
}