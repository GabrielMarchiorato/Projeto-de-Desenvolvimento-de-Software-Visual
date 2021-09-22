using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using proj_semestre_backend.Models;
using proj_semestre_backend.Services;
using Microsoft.AspNetCore.Authorization;

namespace proj_semestre_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : ControllerBase, ICardController
    {       
        public ICardService _cardService;
        public CardController(ICardService cardService) => _cardService = cardService;

        [HttpDelete()]
        [Authorize(Roles = "user")]
        public void deleteCard(int cardId) => 
            this._cardService.deleteCard(Models.User.fromClaims(User.Claims), cardId);
        
        [HttpGet]
        [Authorize(Roles = "user")]
        public List<Card> getCardsForUser() => 
            this._cardService.getCardsForUser(Models.User.fromClaims(User.Claims));

        [HttpPost]
        [Authorize(Roles = "user")]
        public ValueTask<Card> insertCard(Card card) => 
            this._cardService.insertCard(Models.User.fromClaims(User.Claims), card);

        [HttpPatch]
        [Authorize(Roles = "user")]
        public Card updateCardInfo(Card card) =>
            this._cardService.updateCardInfo(Models.User.fromClaims(User.Claims), card);
    }
}