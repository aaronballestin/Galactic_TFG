using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class GetPasapalabraDTO{

        public int Id { get; set;}
        public string Name { get; set;}

        public List<GetPreguntasPasapalabraDTO> Preguntas { get; set;}

        public GetPasapalabraDTO(){
            
        }
    }
}