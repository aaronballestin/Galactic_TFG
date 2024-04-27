using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class GetJuegoDTO{
        public int Id { get; set;}
        public string TemaJuego { get; set;}
        public string Codigo { get; set;}

        public GetJuegoDTO(){

        }
    }
}