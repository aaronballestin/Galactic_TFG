using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class ResultadosPartida{

        [ForeignKey("IdUsuario")]
        public int IdUsuario { get; set;}
        [ForeignKey("IdJuego")]
        public int IdJuego { get; set;}

        public double Resultado  {get; set;}

        public Usuario Usuario{ get; set;}
        public Juego Juego{ get; set;}

        public ResultadosPartida(){
            
        }
    }
}