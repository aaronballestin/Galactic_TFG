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

        [ForeignKey("IdAsignaturaJuego")]
        public int IdAsignaturaJuego { get; set;}

        public AsignaturaJuego AsignaturaJuego{ get; set;}
        public List<Resultados> Resultados{ get; set;}
        public Pasapalabra Pasapalabra{ get; set;}
        public Juego(){

        }
    }
}