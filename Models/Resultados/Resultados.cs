using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class Resultados{

        [Key]
        public int Id { get; set; }

        [ForeignKey("IdUsuario")]
        public int IdUsuario { get; set;}
        [ForeignKey("IdJuego")]
        public int IdJuego { get; set;}

        public double Resultado  {get; set;}

        public char Completado {get; set;}

        public Usuario Usuario{ get; set;}
        public Juego Juego{ get; set;}

        public Resultados(){
            
        }
    }
}