using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalacticApi.Models
{
    public class GetAsignaturaDTO{

        public int Id { get; set;}
        public string NombreAsignatura { get; set;}
        
        public List<GetJuegosDTO> Juegos{ get; set;}

        public GetAsignaturaDTO(){

        }
    }
}