using System;
using Microsoft.AspNetCore.Mvc;
using ProniaTask.Models;

namespace ProniaTask.Areas.Manage.Controllers
{
	public class SliderController
	{
        [Area("Manage")]
        public class SliderController : Controller
        {

            AppDbContext _context;

            public SliderController(AppDbContext context)
            {
                _context = context;
            }

            public IActionResult Index()
            {
                var sliders = _context.Sliders.ToList();
                return View(sliders);
            }

            public IActionResult Create()
            {
                return View();
            }
            [HttpPost]
            public IActionResult Create(Slider slider)
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                _context.Sliders.Add(slider);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            public IActionResult Delete(int id)
            {
                var slider = _context.Sliders.FirstOrDefault(x => x.Id == id);
                if (slider != null)
                {
                    _context.Sliders.Remove(slider);
                    _context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            public IActionResult Update(int id)
            {
                var slider = _context.Sliders.FirstOrDefault(X => X.Id == id);
                if (slider == null)
                {
                    return RedirectToAction("Index");
                }
                return View(slider);
            }
            [HttpPost]
            public IActionResult Update(Slider slider)
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var oldSlider = _context.Sliders.FirstOrDefault(x => x.Id == slider.Id);
                if (oldSlider == null) { return RedirectToAction("Index"); }
                oldSlider.Description = slider.Description;
                oldSlider.HeaderWord = slider.HeaderWord;
                oldSlider.PhotoUrl = slider.PhotoUrl;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}




