using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50), Required(ErrorMessage ="Aee bos saxlama")]
        public string Name { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
