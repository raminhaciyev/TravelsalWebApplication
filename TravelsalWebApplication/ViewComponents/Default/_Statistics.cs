using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelsalWebApplication.ViewComponents.Default
{
    public class _Statistics: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.c1=c.Set<Destination>().Count();
            ViewBag.c2=c.Set<Guide>().Count();
            return View();
        }
    }
}
