using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proj_semestre_backend.Models;
using proj_semestre_backend.Services;
using Microsoft.AspNetCore.Authorization;

namespace proj_semestre_backend.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthController : ControllerBase, IAuthController
    {
        private IAuthService _authService;
        public AuthController(ILogger<AuthController> logger, IAuthService authService) => _authService = authService;

        [HttpPost]
        [Route("login")]
        public dynamic Login([FromBody] AuthCredentialsDTO credentials) {
            try {
                return Ok(_authService.Login(credentials));
            } catch (UnauthorizedAccessException e) {
                return Unauthorized(e.Message);
            } catch (Exception e) {
                Console.WriteLine(e);
                return NoContent();
            }
        }
        
        [HttpPost]
        [Route("sign-up")]        
        public async Task<dynamic> SignUp([FromBody] SignUpCredentialsDTO userData) {
            try {
                return Ok(await _authService.SignUp(userData));
            } catch (Exception) {
                return NoContent();
            }
        }

        [HttpGet]
        [Route("authenticated")]
        [Authorize(Roles = "user")]
        public List<string> Authenticated() { 
            var user = User.Claims .ToList().ConvertAll((e) => e.Value);
            Console.Write(user);
            return user;
        } 
    }
}
