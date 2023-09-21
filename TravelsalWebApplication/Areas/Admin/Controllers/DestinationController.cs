using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelsalWebApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
 
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManager.TListGet();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDestination(Destination p)
        {
           destinationManager.TAdd(p);
            return RedirectToAction("Index");
        }

        
        public IActionResult DeleteDestination(int id)
        {
            var values = destinationManager.TGetById(id);
            destinationManager.TDelete(values);
            return RedirectToAction("Index","Destination", new { area="Admin"});
        }

       [HttpGet]
       public IActionResult UpdateDestination(int id)
        {
            var values = destinationManager.TGetById(id);
            return View(values);
        }


        [HttpPost]
        public IActionResult UpdateDestination(Destination p)
        {
            destinationManager.TUpdate(p);
            return RedirectToAction("Index", "Destination", new { area = "Admin" });
        }
    }
}
