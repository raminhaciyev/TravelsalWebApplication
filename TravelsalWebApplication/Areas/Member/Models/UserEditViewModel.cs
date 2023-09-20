﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelsalWebApplication.Areas.Member.Models
{
    public class UserEditViewModel
    {
        public string name { get; set; }
        public string surname { get; set; }

        [Required(ErrorMessage = "Passwords are not matched")]
        public string password { get; set; }

        [Required(ErrorMessage = "Passwords are not matched")]
        public string confirmpassword { get; set; }


        public string phone { get; set; }
        public string mail { get; set; }
        public string gender { get; set; }
        public string imageurl { get; set; }
        public IFormFile Image { get; set; }
    }
}
