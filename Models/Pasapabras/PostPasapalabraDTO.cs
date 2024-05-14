using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GalacticApi.Models;

namespace GalacticApi.Models
{
    public class PostPasapalabraDTO{

        public string Name { get; set;}
        public int IdJuego { get; set;}
        public int IdCurso { get; set;}
        public int IdAsignatura { get; set;}
        public string TemaJuego { get; set;}


        public List<PostPreguntaPasapalabraDTO> Preguntas { get; set;}

        public PostPasapalabraDTO(){
            
        }
    }
}