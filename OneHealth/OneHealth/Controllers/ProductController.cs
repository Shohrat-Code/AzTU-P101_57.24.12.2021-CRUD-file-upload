using Microsoft.AspNetCore.Mvc;
using OneHealth.Data;
using OneHealth.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmProduct model = new VmProduct()
            {
                Setting = _context.Settings.FirstOrDefault(),
                Socials = _context.Socials.ToList(),
                Products=_context.Products.ToList()
            };

            string cart = Request.Cookies["cart"];
            if (!string.IsNullOrEmpty(cart))
            {
                model.Cart = cart.Split("-").ToList();
            }

            return View(model);
        }
    }
}
