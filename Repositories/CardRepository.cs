using System.Collections.Generic;
using System.Threading.Tasks;
using proj_semestre_backend.Models;
using proj_semestre_backend.Database;
using System.Linq;
using System;

namespace proj_semestre_backend.Repositories
{
    public class CardRepository : ICardRepository
    {
        private ApiContext _context;
        public CardRepository(ApiContext context) => _context = context;
        public void deleteCard(User user, int cardId) 
        {
            var card = _context.Cards.First(card => card.Id == cardId);
            if (card.UserId != user.Id) throw new UnauthorizedAccessException();
            _context.Cards.Remove(card);
            _context.SaveChanges();
        }
        public List<Card> getCardsForUser(User user) => _context.Cards.Where(card => card.UserId == user.Id).ToList();
        public async ValueTask<Card> insertCard(User user, Card card)
        {
            await _context.Cards.AddAsync(card);
            await _context.SaveChangesAsync();
            return card;
        }
        public Card updateCardInfo(User user, Card card)
        {
            if (card.UserId != user.Id) throw new UnauthorizedAccessException();
            _context.Cards.Update(card);
            _context.SaveChanges();
            return card;
        }
    }
}