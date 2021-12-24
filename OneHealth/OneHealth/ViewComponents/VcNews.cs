using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneHealth.Data;
using OneHealth.Models;
using OneHealth.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.ViewComponents
{
    public class VcNews : ViewComponent
    {
        private readonly AppDbContext _context;

        public VcNews(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IViewComponentResult> InvokeAsync(string page)
        {
            VmVcNews model = new VmVcNews();
            if (page == "Home")
            {
                model.Blogs = await _context.Blogs.Include(u => u.User).OrderByDescending(o => o.CreatedDate).Take(3).ToListAsync();
            }
            else
            {
                model.Blogs = await _context.Blogs.Include(u => u.User).OrderByDescending(o => o.CreatedDate).ToListAsync();
            }
            model.Page = page;
            return View(model);
        }
    }
}
