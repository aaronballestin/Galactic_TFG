using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class ResultadosPartida{

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set;}
        [ForeignKey("JuegoId")]
        public int JuegoId { get; set;}

        public Usuario usuario{ get; set;}
        public Juego juego{ get; set;}

        public ResultadosPartida(){
            
        }
    }
}