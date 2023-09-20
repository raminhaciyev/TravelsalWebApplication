using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TravelsalWebApplication.Areas.Member.Models;

namespace TravelsalWebApplication.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
       

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = values.Name + " " + values.Surname;
            ViewBag.userImage = values.ImageUrl;
            ViewBag.userNumber = values.PhoneNumber;
            ViewBag.userMail = values.Email;
            ViewBag.userGender = values.Gender;
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.name = values.Name;
            userEditViewModel.surname = values.Surname;
            userEditViewModel.gender = values.Gender;
            userEditViewModel.mail = values.Email;
            userEditViewModel.phone = values.PhoneNumber;
            return View(userEditViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.name = values.Name;
            userEditViewModel.surname = values.Surname;
            userEditViewModel.gender = values.Gender;
            userEditViewModel.mail = values.Email;
            userEditViewModel.phone = values.PhoneNumber;
            return View(userEditViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.Image!=null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/userimages/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                user.ImageUrl= "/userimages/" + imagename;
            }
            user.Name = p.name;
            user.Surname = p.surname;
            user.Gender = p.gender;
            user.Email = p.mail;
            user.PhoneNumber = p.phone;
            
            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult UpdatePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdatePassword(UserEditViewModel p)
        {
            if (p.password == p.confirmpassword)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.password);
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
           
            return View();
        }
    }
}
