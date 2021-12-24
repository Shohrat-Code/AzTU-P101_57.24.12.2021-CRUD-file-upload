using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Models
{
    public class Specialty
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}
