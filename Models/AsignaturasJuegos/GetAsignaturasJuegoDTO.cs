using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class GetAsignaturasJuegosDTO{
        public int Id { get; set; }
        public string JuegoAsignatura { get; set;}
        public GetAsignaturasJuegosDTO(){

        }
        
    }
}