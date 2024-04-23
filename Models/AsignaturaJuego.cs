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

        public Asignatura asignatura{ get; set;}

        public List<Juego> juegos{ get; set;}
        public AsignaturaJuego(){

        }
        
    }
}