using System.ComponentModel.DataAnnotations;

namespace GalacticApi.Models
{
    public class GetTipoJuegoDTO{
        public int Id { get; set;}
        public string Tipo { get; set;}

        public List<GetJuegosDTO> Juegos{get; set;}

        public GetTipoJuegoDTO(){
            
        }
    }
}