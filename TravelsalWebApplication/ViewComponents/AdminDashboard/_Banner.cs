﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelsalWebApplication.ViewComponents.AdminDashboard
{
    public class _Banner:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
