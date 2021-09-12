using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    }
}