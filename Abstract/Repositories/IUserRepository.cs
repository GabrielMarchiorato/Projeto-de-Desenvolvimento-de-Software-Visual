using proj_semestre_backend.Models;
using System.Threading.Tasks;

namespace proj_semestre_backend.Repositories {
    public interface IUserRepository {
        User Get(AuthCredentialsDTO userCredentials);
        ValueTask<User> AddUser(User user);
    }
}
