using proj_semestre_backend.Models;
using System;
using proj_semestre_backend.Repositories;

using System.Threading.Tasks;

using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Collections.Generic;

namespace proj_semestre_backend.Services {
    public class UserService : IUserService
    {
        IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) => this._userRepository = userRepository;
        public void deleteUser(User user, int Id) => _userRepository.deleteUser(user, Id);
        public List<User> getUser(User user) => _userRepository.getUser(user);
        public User updateUserInfo(User user) => _userRepository.updateUserInfo(user);
    }
}