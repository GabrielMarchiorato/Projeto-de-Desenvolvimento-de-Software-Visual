using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using proj_semestre_backend.Models;
using proj_semestre_backend.Services;
using Microsoft.AspNetCore.Authorization;
using System;


namespace proj_semestre_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovementController : ControllerBase, IMovementController
    {
        public IMovementService _movementService;
        public MovementController(IMovementService movementService) => 
            _movementService = movementService;
        
        [HttpDelete()]
        [Authorize(Roles = "user")]
        public void deleteMovement(int movementId) => 
            this._movementService.deleteMovement(Models.User.fromClaims(User.Claims), movementId);
        
        [HttpGet]
        [Authorize(Roles = "user")]
        public List<Movement> getMovementsForUser() => 
            this._movementService.getMovementsForUser(Models.User.fromClaims(User.Claims));

        [HttpPost]
        [Authorize(Roles = "user")]
        public ValueTask<Movement> insertMovements(Movement movement) => 
            this._movementService.insertMovements(Models.User.fromClaims(User.Claims), movement);

        [HttpPatch]
        [Authorize(Roles = "user")]
        public Movement updateMovementInfo(Movement movement) =>
            this._movementService.updateMovementInfo(Models.User.fromClaims(User.Claims), movement);
    }
}