using proj_semestre_backend.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace proj_semestre_backend.Services {
    public interface ICardService {
        List<Card> getCardsForUser(AuthenticatedUser user);
        ValueTask<Card> insertCard(AuthenticatedUser user);
        ValueTask<int> deleteCard(AuthenticatedUser user);
        ValueTask<Card> updateCardInfo(AuthenticatedUser user);
    }
}