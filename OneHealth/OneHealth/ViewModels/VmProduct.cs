using OneHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.ViewModels
{
    public class VmProduct:VmLayout
    {
        public List<Product> Products { get; set; }
        public List<string> Cart { get; set; }
    }
}
