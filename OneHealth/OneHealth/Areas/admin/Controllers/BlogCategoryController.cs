using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneHealth.Data;
using OneHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Areas.admin.Controllers
{
    [Area("admin")]
    public class BlogCategoryController : Controller
    {
        private readonly AppDbContext _context;

        public BlogCategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category model)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Model valid deyil");
                return View(model);
            }
        }

        public IActionResult Update(int id)
        {
            return View(_context.Categories.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Category model)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Category category = _context.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }

            bool IsRelation = _context.Blogs.Any(c => c.CategoryId == category.Id);

            if (IsRelation)
            {
                HttpContext.Session.SetString("CategoryError", "There is some blog related to the category!");
            }
            else
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
