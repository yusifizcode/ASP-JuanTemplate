using JuanTemplate.DAL;
using Microsoft.AspNetCore.Mvc;

namespace JuanTemplate.Areas.Manage.Controllers
{
    [Area("manage")]
    public class DashboardController : Controller
    {
        private JuanDbContext _context;


        public DashboardController(JuanDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
