using Microsoft.AspNetCore.Mvc;

namespace JuanTemplate.Areas.Manage.Controllers
{
    [Area("manage")]

    public class HomeFeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
