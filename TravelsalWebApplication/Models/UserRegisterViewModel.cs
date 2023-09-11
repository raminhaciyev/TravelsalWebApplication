using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelsalWebApplication.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Please fill your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please fill your Surname")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please fill your mail address")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Please fill your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please fill your password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please repeat your password")]
        [Compare("Password",ErrorMessage ="Passwords are not matched")]
        public string ConfirmPassword { get; set; }
    }
}
