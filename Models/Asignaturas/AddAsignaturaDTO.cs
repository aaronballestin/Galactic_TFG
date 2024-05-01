using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class AddAsignaturaDTO{

        public string NombreAsignatura { get; set;}
        
        public int CursoId { get; set;}


        public AddAsignaturaDTO(){

        }
    }
}