namespace GalacticApi.Models
{
    public class UsuarioDTO{
        public int id {get; set;}
        public string email {get; set;}
        public string nombre {get; set;}
        public string avatar {get; set;}
        public string rol {get; set;}
        public int clase {get; set;}

        public UsuarioDTO(){
            
        }
    }
}