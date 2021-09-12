using proj_semestre_backend.Models;

namespace proj_semestre_backend.Services {
    public interface ITokenService {
        string GenerateToken(User user);
    }
}