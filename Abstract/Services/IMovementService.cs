using proj_semestre_backend.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace proj_semestre_backend.Services {
    public interface IMovementService {
        List<Movement> getMovementsForUser(AuthenticatedUser user);
        ValueTask<Movement> insertMovements(AuthenticatedUser user);
        ValueTask<int> deleteMovement(AuthenticatedUser user);
        ValueTask<Movement> updateMovementInfo(AuthenticatedUser user);
    }
}