using proj_semestre_backend.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace proj_semestre_backend.Controllers
{
    public interface ICardController
    {
        List<Card> getCardsForUser();
        ValueTask<Card> insertCard(Card card);
        void deleteCard(int cardId);
        Card updateCardInfo(Card card);
    }
}