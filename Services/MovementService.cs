using proj_semestre_backend.Models;
using proj_semestre_backend.Repositories;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace proj_semestre_backend.Services {
    public class MovementService: IMovementService {
        private IMovementRepository _movementRepository;
        public MovementService(IMovementRepository movementRepository) => this._movementRepository = movementRepository;
        public void deleteMovement(User user, int movementId) => _movementRepository.deleteMovement(user, movementId);
        public List<Movement> getMovementsForUser(User user) => _movementRepository.getMovementsForUser(user);
        public ValueTask<Movement> insertMovements(User user, Movement movement) => _movementRepository.insertMovements(user, movement);
        public Movement updateMovementInfo(User user, Movement movement) => _movementRepository.updateMovementInfo(user, movement);
    }
}