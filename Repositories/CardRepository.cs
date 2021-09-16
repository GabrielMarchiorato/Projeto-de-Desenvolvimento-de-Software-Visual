using System.Collections.Generic;
using System.Threading.Tasks;
using proj_semestre_backend.Models;
using proj_semestre_backend.Database;
using System.Linq;

namespace proj_semestre_backend.Repositories
{
    public class CardRepository : ICardRepository
    {
        private ApiContext _context;
        public CardRepository(ApiContext context){
            _context = context;
        }
        ValueTask<int> ICardRepository.deleteCard(AuthenticatedUser user)
        {
            throw new System.NotImplementedException();
        }

        List<Card> ICardRepository.getCardsForUser(AuthenticatedUser user)
        {
            throw new System.NotImplementedException();
        }

        ValueTask<Card> ICardRepository.insertCard(AuthenticatedUser user)
        {
            throw new System.NotImplementedException();
        }

        ValueTask<Card> ICardRepository.updateCardInfo(AuthenticatedUser user)
        {
            throw new System.NotImplementedException();
        }
    }
}