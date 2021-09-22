using System.Collections.Generic;
using proj_semestre_backend.Models;
using System.Threading.Tasks;

namespace proj_semestre_backend.Repositories {
    public interface ICardRepository 
    {
        List<Card> getCardsForUser(User user);
        ValueTask<Card> insertCard(User user, Card card);
        void deleteCard(User user, int cardId);
        Card updateCardInfo(User user, Card oldCard);
    }
}
