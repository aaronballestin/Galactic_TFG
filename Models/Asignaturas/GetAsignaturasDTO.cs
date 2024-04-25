using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class GetAsignaturasDTO{

        public int Id { get; set;}
        public string NombreAsignatura { get; set;}
        
        public GetAsignaturasDTO(){

        }
    }
}