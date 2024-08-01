namespace PokemonAPI.Models
{
    public class ResponseHabilidades
    {
        public List<string> Ocultas { get; set; }
    }

    public class PokemonHabilidadResponse
    {
        public ResponseHabilidades Habilidades { get; set; }
    }
}