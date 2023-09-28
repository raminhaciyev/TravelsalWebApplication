using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelsalWebApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.TListGet());
            return Json(jsonCity);
        }


        [HttpPost]
        public IActionResult AddCity(Destination p)
        {
            p.Status = true;
            _destinationService.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
    }
}
