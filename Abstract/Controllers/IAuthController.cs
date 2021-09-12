using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proj_semestre_backend.Models;

namespace proj_semestre_backend.Controllers {
    interface IAuthController {
        dynamic Login(AuthCredentialsDTO model);

        Task<dynamic> SignUp(User model);
    }
}