using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class BuscadorFormulario{
        public int IdCurso { get; set;}
        public int IdAsignatura { get; set;}
        public int IdTipoJuego { get; set;}

        public BuscadorFormulario(){

        }
    }
}