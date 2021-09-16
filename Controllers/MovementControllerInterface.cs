using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using proj_semestre_backend.Models;

namespace proj_semestre_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovementControllerInterface : ControllerBase, IMovementController
    {
        ValueTask<int> IMovementController.deleteMovement(AuthenticatedUser user)
        {
            throw new System.NotImplementedException();
        }

        List<Movement> IMovementController.getMovementsForUser(AuthenticatedUser user)
        {
            throw new System.NotImplementedException();
        }

        ValueTask<Movement> IMovementController.insertMovements(AuthenticatedUser user)
        {
            throw new System.NotImplementedException();
        }

        ValueTask<Movement> IMovementController.updateMovementInfo(AuthenticatedUser user)
        {
            throw new System.NotImplementedException();
        }
    }
}