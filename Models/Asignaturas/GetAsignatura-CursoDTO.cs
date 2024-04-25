using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class AsignaturaCursoDTO{

        public int Id { get; set;}
        public string NombreAsignatura { get; set;}
        
        public AsignaturaCursoDTO(){

        }
    }
}