using JuanTemplate.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanTemplate.Controllers
{
    public class ShopController : Controller
    {
        private JuanDbContext _context;

        public ShopController(JuanDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
