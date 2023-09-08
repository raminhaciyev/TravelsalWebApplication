using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelsalWebApplication.ViewComponents.Default
{
    public class _Feature: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            Feature f = new Feature();
            ViewBag.c3 = f.Description;
            ViewBag.c2 = f.Title;
            ViewBag.c1 = f.Image;
            return View();
        }
    }
}
