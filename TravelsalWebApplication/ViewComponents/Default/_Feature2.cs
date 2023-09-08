using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelsalWebApplication.ViewComponents.Default
{
    public class _Feature2: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
