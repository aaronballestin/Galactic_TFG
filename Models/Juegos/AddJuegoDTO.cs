using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class AddJuegoDTO{
        public string TemaJuego { get; set;}
        public int IdAsignaturaJuego { get; set;}

        public int TipoJuego { get; set;}

        public AddJuegoDTO(){

        }
    }
}