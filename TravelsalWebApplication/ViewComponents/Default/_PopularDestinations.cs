using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelsalWebApplication.ViewComponents.Default
{
    public class _PopularDestinations: ViewComponent
    {
        DestinationManager destination = new DestinationManager(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            var values = destination.TListGetStatusTrue();
            return View(values);
        }
    }
}
