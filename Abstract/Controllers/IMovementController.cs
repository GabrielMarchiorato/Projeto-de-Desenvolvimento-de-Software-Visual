using proj_semestre_backend.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace proj_semestre_backend.Controllers
{
    public interface IMovementController
    {
        List<Movement> getMovementsForUser();
        ValueTask<Movement> insertMovements(Movement movement);
        void deleteMovement(int movementId);
        Movement updateMovementInfo(Movement movement);
    }
}