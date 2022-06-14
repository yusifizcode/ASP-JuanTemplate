using JuanTemplate.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanTemplate.Areas.Manage.Controllers
{
    [Area("manage")]
    public class CategoryController : Controller
    {
        private JuanDbContext _context;

        public CategoryController(JuanDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var categories = _context.Categories.Include(x=>x.ProductCategories).ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
