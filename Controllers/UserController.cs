using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proj_semestre_backend.Models;
using proj_semestre_backend.Services;
using Microsoft.AspNetCore.Authorization;

namespace Projeto_de_Desenvolvimento_de_Software_Visual.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase, IUserController
    {       
        public IUserService _userService;
        public userController(IUserService userService) => _userService = userService;

        [HttpDelete()]
        [Authorize(Roles = "user")]
        public void deleteUser(int Id) => 
            this._userService.deleteUser(Models.User.fromClaims(User.Claims), Id);

        [HttpPatch]
        [Authorize(Roles = "user")]
        public User updateUserInfo(User user) =>
            this._userService.updateUserInfo(Models.User.fromClaims(User.Claims), Id);
    }
}