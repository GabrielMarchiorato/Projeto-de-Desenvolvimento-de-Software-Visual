using proj_semestre_backend.Models;
using System;
using proj_semestre_backend.Repositories;

using System.Threading.Tasks;

using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Collections.Generic;

namespace proj_semestre_backend.Services {
    public class MovementService: IMovementService {
        private IMovementRepository _movementRepository;
        public MovementService(
            IMovementRepository movementRepository
        ) {
            this._movementRepository = movementRepository;
        }

        ValueTask<int> IMovementService.deleteMovement(AuthenticatedUser user)
        {
            throw new NotImplementedException();
        }

        List<Movement> IMovementService.getMovementsForUser(AuthenticatedUser user)
        {
            throw new NotImplementedException();
        }

        ValueTask<Movement> IMovementService.insertMovements(AuthenticatedUser user)
        {
            throw new NotImplementedException();
        }

        ValueTask<Movement> IMovementService.updateMovementInfo(AuthenticatedUser user)
        {
            throw new NotImplementedException();
        }
    }
}