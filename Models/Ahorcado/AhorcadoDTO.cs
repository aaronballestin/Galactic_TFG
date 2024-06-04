using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class AhorcadoDTO{

        public int Id { get; set;}
        public string Name { get; set;}
        public int IdJuego { get; set;}

        public PreguntaAhorcadoDTO PreguntaAhorcado {get; set;}

        public AhorcadoDTO(){
            
        }
    }
}