using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace proj_semestre_backend.Models
{
    [Table("Movements")]
    public class Movement
    {
        [Key]
        public int Id { get; set; }
        public string type { get; set; }
        public string method { get; set; }
        public float value { get; set; }
        public int UserId { get; set; }
    }
}