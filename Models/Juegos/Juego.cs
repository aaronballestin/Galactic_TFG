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

        [ForeignKey("IdAsignatura")]
        public int IdAsignatura { get; set;}

        [ForeignKey("IdCurso")]
        public int IdCurso { get; set;}

        [ForeignKey("IdTipoJuego")]
        public int IdTipoJuego { get; set;}

        public Asignatura Asignatura{ get; set;}
        public TipoJuego TipoJuego{ get; set;}
        public Curso Curso{ get; set;}

        public List<Resultados> Resultados{ get; set;}
        public Pasapalabra Pasapalabra{ get; set;}
        public Juego(){

        }
    }
}