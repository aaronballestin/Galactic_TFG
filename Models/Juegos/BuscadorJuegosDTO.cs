using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class BuscadorJuegosDTO{
        public int Id { get; set;}
        public string TemaJuego { get; set;}
        public string Codigo { get; set;}

        public int IdAsignatura { get; set;}

        public int IdCurso { get; set;}

        public int IdTipoJuego { get; set;}

        public BuscadorJuegosDTO(){

        }
    }
}