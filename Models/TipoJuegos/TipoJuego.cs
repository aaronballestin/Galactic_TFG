using System.ComponentModel.DataAnnotations;

namespace GalacticApi.Models
{
    public class TipoJuego{
        [Key]
        public int Id { get; set;}
        [Required]
        public string Tipo { get; set;}

        public List<Juego> Juegos{get; set;}

        public TipoJuego(){
            
        }
    }
}