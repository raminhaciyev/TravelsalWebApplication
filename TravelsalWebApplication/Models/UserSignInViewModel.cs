using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelsalWebApplication.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Please write your username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please write your password")]
        public string Password { get; set; }
    }
}
