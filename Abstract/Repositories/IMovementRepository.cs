using System.Collections.Generic;
using proj_semestre_backend.Models;
using System.Threading.Tasks;

namespace proj_semestre_backend.Repositories {
    public interface IMovementRepository
    {
        List<Movement> getMovementsForUser(AuthenticatedUser user);
        ValueTask<Movement> insertMovements(AuthenticatedUser user);
        ValueTask<int> deleteMovement(AuthenticatedUser user);
        ValueTask<Movement> updateMovementInfo(AuthenticatedUser user);
    }
}
