using System.Collections.Generic;

namespace PokemonAPI.Models
{
    public class Ability
    {
        public AbilityDetail AbilityDetail { get; set; }
        public bool is_hidden { get; set; }
    }

    public class AbilityDetail
    {
        public string Name { get; set; }
    }

    public class ResponsePokemones
    {
        public List<Ability> Abilities { get; set; }
    }
}