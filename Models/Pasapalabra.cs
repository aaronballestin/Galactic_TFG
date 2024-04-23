namespace GalacticApi.Models
{
    public class Pasapalabra{
        public int Id { get; set;}
        public string Name { get; set;}

        public int IdJuego { get; set;}


        public Juego juego{ get; set;}

        public Pasapalabra(){
            
        }
    }
}