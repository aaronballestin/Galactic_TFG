using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class GetResultadosDTO{


        public int IdUsuario { get; set;}
        public int IdJuego { get; set;}
        public char Completado {get; set;}
        public double Resultado  {get; set;}


        public GetResultadosDTO(){
            
        }
    }
}