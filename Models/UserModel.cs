using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
namespace proj_semestre_backend.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Salt { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public List<Card> Cards { get; set; }
        public List<Movement> Movements { get; set; }

        public static User fromClaims(IEnumerable<System.Security.Claims.Claim> claims) {
            var data = claims.ToList().ConvertAll((e) => e.Value);
            return new User() {
                Username = data[0],
                Role = data[1],
                Id = System.Convert.ToInt32(data[2]),
            };
        }
    }
}