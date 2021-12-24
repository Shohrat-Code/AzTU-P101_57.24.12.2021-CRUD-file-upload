using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneHealth.Data;
using OneHealth.Models;
using OneHealth.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Controllers
{
    public class DoctorController : Controller
    {
        private readonly AppDbContext _context;

        public DoctorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmDoctor model = new VmDoctor();
            model.Doctors = _context.Doctors.Include("Specialty").ToList();
            model.Setting = _context.Settings.FirstOrDefault();
            model.Socials = _context.Socials.ToList();

            //HttpContext.Session.Remove("UserId");
            return View(model);
        }
    }
}
