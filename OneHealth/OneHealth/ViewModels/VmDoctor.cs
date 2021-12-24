using OneHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.ViewModels
{
    public class VmDoctor : VmLayout
    {
        public List<Doctor> Doctors { get; set; }
    }
}
