using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneHealth.Data;
using OneHealth.Models;
using OneHealth.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //ViewBag.UserId = HttpContext.Session.GetString("UserId");
            //ViewBag.Cart = Request.Cookies["cart"];

            VmHome model = new VmHome();
            model.Setting = _context.Settings.FirstOrDefault();
            model.Socials = _context.Socials.ToList();
            return View(model);
        }
    }
}
