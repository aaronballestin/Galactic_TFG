using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class GetAsignaturaDTO{

        public int Id { get; set;}
        public string NombreAsignatura { get; set;}
        
        public List<GetAsignaturasJuegosDTO> AsignaturasJuegos{ get; set;}

        public GetAsignaturaDTO(){

        }
    }
}