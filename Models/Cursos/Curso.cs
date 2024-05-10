using System.ComponentModel.DataAnnotations;

namespace GalacticApi.Models
{
    public class Curso{

        [Key]
        public int CursoId { get; set;}
        
        [Required]
        public string NombreCurso { get; set;}

        public List<Juego> Juegos{ get; set;}

        public Curso(){
            
        }
    }
}