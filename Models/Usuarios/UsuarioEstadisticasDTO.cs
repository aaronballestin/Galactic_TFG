using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class UsuarioEstadisticasDTO{
        public int Id { get; set; }
        public string Name { get; set;}
        public string Email { get; set;}
        public double Media { get; set;}
        public double JuegosCompletados { get; set;}
        public int Acertadas { get; set;}
        public int Falladas { get; set;}
        public List<GetResultadosDTO> Resultados{ get; set;}

        public UsuarioEstadisticasDTO (){

        }
    }
}