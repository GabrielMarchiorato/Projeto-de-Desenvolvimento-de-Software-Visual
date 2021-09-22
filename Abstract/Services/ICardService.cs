using proj_semestre_backend.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace proj_semestre_backend.Services {
    public interface ICardService {
        List<Card> getCardsForUser(User user);
        ValueTask<Card> insertCard(User user, Card card);
        void deleteCard(User user, int cardId);
        Card updateCardInfo(User user, Card card);
    }
}