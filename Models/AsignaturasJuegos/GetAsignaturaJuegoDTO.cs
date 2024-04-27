using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class GetAsignaturaJuegoDTO{
        public int Id { get; set; }
        
        public string JuegoAsignatura { get; set;}


        public List<GetJuegosDTO> Juegos{ get; set;}
        public GetAsignaturaJuegoDTO(){

        }
        
    }
}