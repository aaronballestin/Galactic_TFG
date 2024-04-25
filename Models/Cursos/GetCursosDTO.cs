using System.ComponentModel.DataAnnotations;

namespace GalacticApi.Models
{
    public class GetCursosDTO{

        public int Id { get; set;}
        
        public string NombreCurso { get; set;}


        public GetCursosDTO(){
            
        }
    }
}