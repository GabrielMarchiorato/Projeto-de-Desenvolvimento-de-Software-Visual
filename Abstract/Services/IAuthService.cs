using proj_semestre_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace proj_semestre_backend.Services {
    public interface IAuthService {
        AuthenticatedUser Login(AuthCredentialsDTO model);
        ValueTask<User> SignUp(User model);
    }
}