using System.Collections.Generic;
using proj_semestre_backend.Models;
using System.Threading.Tasks;

namespace proj_semestre_backend.Repositories {
    public interface ICardRepository 
    {
        List<Card> getCardsForUser(AuthenticatedUser user);
        ValueTask<Card> insertCard(AuthenticatedUser user);
        ValueTask<int> deleteCard(AuthenticatedUser user);
        ValueTask<Card> updateCardInfo(AuthenticatedUser user);
    }
}
