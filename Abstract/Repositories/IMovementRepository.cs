using System.Collections.Generic;
using proj_semestre_backend.Models;
using System.Threading.Tasks;

namespace proj_semestre_backend.Repositories {
    public interface IMovementRepository
    {
        List<Movement> getMovementsForUser(User user);
        ValueTask<Movement> insertMovements(User user, Movement movement);
        void deleteMovement(User user, int movementId);
        Movement updateMovementInfo(User user, Movement movement);
    }
}
