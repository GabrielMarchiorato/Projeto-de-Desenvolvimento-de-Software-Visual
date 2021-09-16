using proj_semestre_backend.Models;
using System.Threading.Tasks;
namespace proj_semestre_backend.Services {
    public interface IAuthService {
        AuthenticatedUser Login(AuthCredentialsDTO model);
        ValueTask<User> SignUp(SignUpCredentialsDTO model);
    }
}