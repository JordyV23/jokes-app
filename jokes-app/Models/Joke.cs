namespace jokes_app.Models
{
    public class Joke
    {
        // Declaracion de propiedades de la clase Joke
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }

        // Declaracion de constructor
        public Joke()
        {
            
        }
    }
}
