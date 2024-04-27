using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class AsignaturaJuego{
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string JuegoAsignatura { get; set;}

        [ForeignKey("IdAsignatura")]
        public int IdAsignatura { get; set;}
        [ForeignKey("IdTipoJuego")]
        public int IdTipoJuego {get; set;}

        public Asignatura Asignatura{ get; set;}
        public TipoJuego TipoJuego{ get; set;}
        public List<Juego> Juegos{ get; set;}
        public AsignaturaJuego(){

        }
        
    }
}