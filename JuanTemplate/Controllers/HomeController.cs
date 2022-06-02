using JuanTemplate.DAL;
using JuanTemplate.Models;
using JuanTemplate.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JuanTemplate.Controllers
{
    public class HomeController : Controller
    {
        private JuanDbContext _context;

        public HomeController(JuanDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                HomeSliders = _context.HomeSliders.ToList(),
                HomeFeatures = _context.HomeFeatures.ToList()
            };
            return View(homeVM);
        }

        
    }
}
