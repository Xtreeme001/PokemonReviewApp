using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon>GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);

        decimal GetPokemonRating(int pokeId);
        bool PokemonExists(int  pokemonId);
        bool CreatePokemon(int ownerId , int categoryId , Pokemon pokemon);
        bool UpdatePokemon(Pokemon pokemon);
        bool DeletePokemon(Pokemon pokemon);
        bool Save();
    }
}
