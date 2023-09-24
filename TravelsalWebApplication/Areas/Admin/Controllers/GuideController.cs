using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelsalWebApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var values = _guideService.TListGet();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGuide(Guide p)
        {
            _guideService.TAdd(p);
            return RedirectToAction("Index", "Guide");
        }

        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var values = _guideService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditGuide(Guide p)
        {
            _guideService.TUpdate(p);
            return RedirectToAction("Index","Guide");
        }
    }
}
