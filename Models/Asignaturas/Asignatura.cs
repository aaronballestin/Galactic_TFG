using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class Asignatura{

        [Key]
        public int Id { get; set;}
        [Required]
        public string NombreAsignatura { get; set;}
        
        [ForeignKey("CursoId")]
        public int CursoId { get; set;}

        public Curso Curso{ get; set;}

        public List<AsignaturaJuego> AsignaturaJuegos{ get; set;}

        public Asignatura(){

        }
    }
}