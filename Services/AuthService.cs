using proj_semestre_backend.Models;
using System;
using proj_semestre_backend.Repositories;

using System.Threading.Tasks;

using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace proj_semestre_backend.Services {
    public class AuthService: IAuthService {

        private readonly IUserRepository _userRepository;
        private ITokenService _tokenService;
        public AuthService(IUserRepository userRepository, ITokenService tokenService) {
            _userRepository = userRepository;
            _tokenService = tokenService;
        }
        public AuthenticatedUser Login(AuthCredentialsDTO userCredentials) {

            User user =  _userRepository.Get(userCredentials);

            if (user == null) {
                throw new UnauthorizedAccessException("User not found");
            }

            if (user.Password != this.Hash(userCredentials.password, Convert.FromBase64String(user.Salt))) {
                throw new UnauthorizedAccessException("Password doesn't match");
            }

            user.Password = "";

            return new AuthenticatedUser { user = user, token = _tokenService.GenerateToken(user)};
        }
        public async ValueTask<User> SignUp(User user) {
            byte[] salt = new byte[128 / 8];

            using (var rngCsp = new RNGCryptoServiceProvider()) { rngCsp.GetNonZeroBytes(salt); }

            user.Salt = Convert.ToBase64String(salt);
            user.Password = this.Hash(user.Password, salt);

            var createdUser = await _userRepository.AddUser(user);
            return createdUser;
        }

        private string Hash(string password, byte[] salt) => Convert.ToBase64String(
            KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8
            )
        );

    }
}