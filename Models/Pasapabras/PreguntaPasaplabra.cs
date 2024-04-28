using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class PreguntaPasapalabra{
        [Key]
        public int Id { get; set; } 
        [Required]
        public string Pregunta { get; set;} 
        [Required]
        public string Respuesta { get; set; }
        [Required]
        public char Letra { get; set; }
        [ForeignKey("IdPasapalabra")]
        public int IdPasapalabra { get; set; }    

        public Pasapalabra Pasapalabra{ get; set; }

        public PreguntaPasapalabra(){

        }
    }
}