using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class GetResultadosAsignaturaDTO{


        public int IdJuego { get; set;}
        public int IdAsignatura { get; set;}
        public char Completado {get; set;}
        public double Resultado  {get; set;}


        public GetResultadosAsignaturaDTO(){
            
        }
    }
}