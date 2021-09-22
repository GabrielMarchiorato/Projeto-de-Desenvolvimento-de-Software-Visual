using proj_semestre_backend.Models;
using System;
using proj_semestre_backend.Repositories;

using System.Threading.Tasks;

using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Collections.Generic;

namespace proj_semestre_backend.Services {
    public class CardService : ICardService
    {
        ICardRepository _cardRepository;
        public CardService(ICardRepository cardRepository) => this._cardRepository = cardRepository;
        public void deleteCard(User user, int cardId) => _cardRepository.deleteCard(user, cardId);
        public List<Card> getCardsForUser(User user) => _cardRepository.getCardsForUser(user);
        public ValueTask<Card> insertCard(User user, Card card) => _cardRepository.insertCard(user, card);
        public Card updateCardInfo(User user, Card card) => _cardRepository.updateCardInfo(user, card);
    }
}