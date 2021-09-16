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
        public CardService(ICardRepository cardRepository)
        {
            this._cardRepository = cardRepository;
        }

        public ValueTask<int> deleteCard(AuthenticatedUser user)
        {
            throw new NotImplementedException();
        }

        public List<Card> getCardsForUser(AuthenticatedUser user)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Card> insertCard(AuthenticatedUser user)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Card> updateCardInfo(AuthenticatedUser user)
        {
            throw new NotImplementedException();
        }
    }
}