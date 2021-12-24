using OneHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.ViewModels
{
    public class VmHome : VmLayout
    {
        public List<Service> Services { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Blog> Blogs { get; set; }
        public Blog Blog { get; set; }
    }
}
