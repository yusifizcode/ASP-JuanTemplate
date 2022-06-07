using JuanTemplate.DAL;
using JuanTemplate.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace JuanTemplate.Areas.Manage.Controllers
{
    [Area("manage")]
    public class HomeSliderController : Controller
    {
        private JuanDbContext _context;

        public HomeSliderController(JuanDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.HomeSliders.ToList();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(HomeSlider slider)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _context.HomeSliders.Add(slider);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            HomeSlider slider = _context.HomeSliders.FirstOrDefault(x => x.Id == id);

            if (slider == null)
                return RedirectToAction("error", "dashboard");

            return View(slider);
        }

        [HttpPost]
        public IActionResult Edit(HomeSlider slider)
        {
            if (!ModelState.IsValid)
                return View();

            HomeSlider existSlider = _context.HomeSliders.FirstOrDefault(x => x.Id == slider.Id);

            if (existSlider == null)
                return RedirectToAction("error", "dashboard");

            existSlider.Title = slider.Title;
            existSlider.Subtitle = slider.Subtitle;
            existSlider.Desc = slider.Desc;
            existSlider.BtnText = slider.BtnText;

            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            HomeSlider slider = _context.HomeSliders.FirstOrDefault(x => x.Id == id);

            if (slider == null)
                return RedirectToAction("error", "dashboard");

            return View(slider);
        }

        [HttpPost]
        public IActionResult Delete(HomeSlider slider)
        {
            HomeSlider existSlider = _context.HomeSliders.FirstOrDefault(x => x.Id == slider.Id);


            if (existSlider == null)
                return RedirectToAction("error", "dashboard");

            _context.HomeSliders.Remove(existSlider);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
