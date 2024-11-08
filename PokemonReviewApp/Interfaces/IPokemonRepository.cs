using PokemonReviewApp.Moels;

namespace PokemonReviewApp.Interfaces
{
    public interface IPokemonRepository
    {
         ICollection<Pokemon> GetPokemons();
    }
}
