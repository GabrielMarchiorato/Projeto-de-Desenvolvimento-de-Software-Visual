using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using proj_semestre_backend.Models;

namespace proj_semestre_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : ControllerBase, ICardControllerInterface
    {
        ValueTask<int> ICardControllerInterface.deleteCard(AuthenticatedUser user)
        {
            throw new System.NotImplementedException();
        }

        List<Card> ICardControllerInterface.getCardsForUser(AuthenticatedUser user)
        {
            throw new System.NotImplementedException();
        }

        ValueTask<Card> ICardControllerInterface.insertCard(AuthenticatedUser user)
        {
            throw new System.NotImplementedException();
        }

        ValueTask<Card> ICardControllerInterface.updateCardInfo(AuthenticatedUser user)
        {
            throw new System.NotImplementedException();
        }
    }
}