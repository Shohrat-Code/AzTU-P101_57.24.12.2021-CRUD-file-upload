using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Fullname { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }
        [MaxLength(500)]
        public string Subject { get; set; }
        [Column(TypeName = "ntext")]
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
