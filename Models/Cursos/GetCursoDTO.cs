using System.ComponentModel.DataAnnotations;

namespace GalacticApi.Models
{
    public class GetCursoDTO{

        public int Id { get; set;}
        
        public string NombreCurso { get; set;}

        public List<GetJuegosDTO> Juegos{ get; set;}


        public GetCursoDTO(){
            
        }
    }
}