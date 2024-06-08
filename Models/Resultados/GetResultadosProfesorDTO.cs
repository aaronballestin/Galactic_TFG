using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class GetResultadosProfesorDTO{


        public string Usuario { get; set;}
        public string Juego { get; set;}
        public double Resultado  {get; set;}
        public int Acertadas {get; set;}
        public int Falladas {get; set;}


        public GetResultadosProfesorDTO(){
            
        }
    }
}