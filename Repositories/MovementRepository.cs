using System.Collections.Generic;
using System.Threading.Tasks;
using proj_semestre_backend.Database;
using proj_semestre_backend.Models;
using System.Linq;

namespace proj_semestre_backend.Repositories
{
    public class MovementRepository : IMovementRepository
    {        
        private ApiContext _context;
        public MovementRepository(ApiContext context){
            _context = context;
        }        
        ValueTask<int> IMovementRepository.deleteMovement(AuthenticatedUser user)
        {
            throw new System.NotImplementedException();
        }

        List<Movement> IMovementRepository.getMovementsForUser(AuthenticatedUser user)
        {
            throw new System.NotImplementedException();
        }

        ValueTask<Movement> IMovementRepository.insertMovements(AuthenticatedUser user)
        {
            throw new System.NotImplementedException();
        }

        ValueTask<Movement> IMovementRepository.updateMovementInfo(AuthenticatedUser user)
        {
            throw new System.NotImplementedException();
        }
    }
}