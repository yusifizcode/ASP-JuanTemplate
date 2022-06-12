using JuanTemplate.DAL;
using JuanTemplate.Helpers;
using JuanTemplate.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace JuanTemplate.Areas.Manage.Controllers
{
    [Area("manage")]
    public class HomeSliderController : Controller
    {
        private JuanDbContext _context;
        private IWebHostEnvironment _env;

        public HomeSliderController(JuanDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
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


            if(slider.ImageFile != null)
            {
                if(slider.ImageFile.ContentType != "image/png" && slider.ImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("ImageFile", "File format must be image/png or image/jpeg");
                }
                if(slider.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "File size must be less than 2MB");
                }
            }
            else
            {
                ModelState.AddModelError("ImageFile","Image file is required!");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            slider.Image = FileManager.Save(_env.WebRootPath,"uploads/sliders",slider.ImageFile);

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

            FileManager.Delete(_env.WebRootPath, "uploads/sliders", existSlider.Image);

            _context.HomeSliders.Remove(existSlider);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
