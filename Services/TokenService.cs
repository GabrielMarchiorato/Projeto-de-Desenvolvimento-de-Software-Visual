using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using proj_semestre_backend.Models;
using Microsoft.IdentityModel.Tokens;

namespace proj_semestre_backend.Services
{
    public class TokenService: ITokenService
    {
        public TokenService(){}
        public string GenerateToken(User user) 
        {

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Settings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(
                        ClaimTypes.Name,
                        user.Username.ToString()),
                    new Claim(
                        ClaimTypes.Role,
                        user.Role.ToString()),
                    new Claim(
                        ClaimTypes.NameIdentifier,
                        user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}