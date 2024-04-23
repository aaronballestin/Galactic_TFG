using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class Asignatura{

        [Key]
        public int Id { get; set;}
        [Required]
        public string NombreAsignatura { get; set;}
        
        [ForeignKey("IdCurso")]
        public int IdCurso { get; set;}

        public Curso curso{ get; set;}

        public Asignatura(){
            
        }
    }
}