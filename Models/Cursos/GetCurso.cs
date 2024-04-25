using System.ComponentModel.DataAnnotations;

namespace GalacticApi.Models
{
    public class GetCurso{

        public int Id { get; set;}
        
        public string NombreCurso { get; set;}

        public List<AsignaturaCursoDTO> Asignaturas{ get; set;}


        public GetCurso(){
            
        }
    }
}