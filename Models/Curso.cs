using System.ComponentModel.DataAnnotations;

namespace GalacticApi.Models
{
    public class Curso{

        [Key]
        public int Id { get; set;}
        
        [Required]
        public string NombreCurso { get; set;}

        public List<Asignatura> Asignaturas{ get; set;}

        public Curso(){
            
        }
    }
}