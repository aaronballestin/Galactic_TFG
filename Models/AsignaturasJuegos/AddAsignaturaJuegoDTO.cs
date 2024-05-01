using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class AddAsignaturaJuegoDTO{
        public string JuegoAsignatura { get; set;}

        public int IdAsignatura { get; set;}

        public AddAsignaturaJuegoDTO(){

        }
        
    }
}