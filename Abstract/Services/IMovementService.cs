using proj_semestre_backend.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace proj_semestre_backend.Services {
    public interface IMovementService {
        List<Movement> getMovementsForUser(User user);
        ValueTask<Movement> insertMovements(User user, Movement movement);
        void deleteMovement(User user, int movementId);
        Movement updateMovementInfo(User user, Movement movement);
    }
}