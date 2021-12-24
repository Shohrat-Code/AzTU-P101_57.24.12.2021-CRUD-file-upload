using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneHealth.Data;
using OneHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.ViewComponents
{
    public class RecentBlog : ViewComponent
    {
        private readonly AppDbContext _context;

        public RecentBlog(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Blog> blogs = await _context.Blogs.Include(u => u.User).OrderByDescending(o => o.CreatedDate).Take(3).ToListAsync();
            return View(blogs);
        }
    }
}
