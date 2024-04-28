using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class GetPreguntasPasapalabraDTO{
        public int Id { get; set; } 
        public string Pregunta { get; set;} 
        public string Respuesta { get; set; }
        public char Letra { get; set; }

        public GetPreguntasPasapalabraDTO(){

        }
    }
}