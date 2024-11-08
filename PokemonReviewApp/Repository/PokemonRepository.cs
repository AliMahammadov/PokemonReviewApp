using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Moels;

namespace PokemonReviewApp.Repository
{
    public class PokemonRepository  : IPokemonRepository
    {
        private readonly DataContext _context;

        public PokemonRepository(DataContext context)
        {
            _context = context;
        }

        ICollection<Pokemon> IPokemonRepository.GetPokemons()
        {
            return _context.Pokemon.OrderBy(p=>p.Id).ToList();
        }

     
    }
}
