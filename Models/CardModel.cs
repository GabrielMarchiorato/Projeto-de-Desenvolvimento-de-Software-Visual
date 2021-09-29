using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace proj_semestre_backend.Models
{
    [Table("Cards")]
    public class Card
    {
        [Key]
        public int Id { get; set; }
        public string Number { get; set; }
        public string CardHolder { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int UserId { get; set; }
        public List<Movement> Movements { get; set; }
    }
}