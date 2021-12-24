using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(500)]
        public string Adress { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; }
        [MaxLength(500)]
        public string AboutTitle { get; set; }
        [Column(TypeName = "ntext")]
        public string About { get; set; }
        [MaxLength(250)]
        public string BgImage { get; set; }
        [MaxLength(150)]
        public string Title { get; set; }
        [MaxLength(150)]
        public string UpTitle { get; set; }
        [MaxLength(250)]
        public string AboutImage { get; set; }
    }
}
