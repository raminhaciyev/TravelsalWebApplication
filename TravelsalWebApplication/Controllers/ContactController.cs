using AutoMapper;
using BusinessLayer.Abstract;
using DTOLaye.DTOs.ContactDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelsalWebApplication.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactMessageService _contactMessageService;
        private readonly IMapper _mapper;

        public ContactController(IContactMessageService contactMessageService, IMapper mapper)
        {
            _contactMessageService = contactMessageService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SendMessageDto model)
        {
            if (ModelState.IsValid)
            {
                _contactMessageService.TAdd(new ContactMessage()
                {
                    Subject = model.Subject,
                    MessageBody = model.MessageBody,
                    Mail = model.Mail,
                    Status = true,
                    Name = model.Name,
                    MessageDate = Convert.ToDateTime(DateTime.Now.ToShortTimeString())
                });

                return RedirectToAction("Index","Default");
            }
            return View(model);
        }
    }
}
