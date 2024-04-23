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
        public char letra { get; set; }
        [ForeignKey("IdPasapalabra")]
        public int IdPasalabra { get; set; }    

        public Pasapalabra pasapalabra{ get; set; }

        public PreguntaPasapalabra(){

        }
    }
}