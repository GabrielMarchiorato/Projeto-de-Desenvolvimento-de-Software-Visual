using System.Collections.Generic;
using System.Threading.Tasks;
using proj_semestre_backend.Database;
using proj_semestre_backend.Models;
using System.Linq;
using System;
namespace proj_semestre_backend.Repositories
{
    public class MovementRepository : IMovementRepository
    {        
        private ApiContext _context;
        public MovementRepository(ApiContext context) => _context = context;
        public void deleteMovement(User user, int movementId) 
        {
            var movement = _context.Movements.First(m => m.Id == movementId);
            if (movement.UserId != user.Id) throw new UnauthorizedAccessException();
            _context.Movements.Remove(movement);
            _context.SaveChanges();
        }
        public List<Movement> getMovementsForUser(User user) => 
            _context.Movements.Where(movement => movement.UserId == user.Id).ToList();
        public async ValueTask<Movement> insertMovements(User user, Movement movement)
        {
            await _context.Movements.AddAsync(movement);
            await _context.SaveChangesAsync();
            return movement;
        }
        public Movement updateMovementInfo(User user, Movement movement)
        {
            if (movement.UserId != user.Id) throw new UnauthorizedAccessException();
            _context.Movements.Update(movement);
            _context.SaveChanges();
            return movement;
        }
    }
}