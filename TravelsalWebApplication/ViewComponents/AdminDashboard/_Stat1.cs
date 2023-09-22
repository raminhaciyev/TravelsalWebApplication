using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelsalWebApplication.ViewComponents.AdminDashboard
{
    public class _Stat1:ViewComponent
    {
        Context x = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = x.Destinations.Count();
            ViewBag.v2 = x.Users.Count();
            return View();
        }
    }
}
