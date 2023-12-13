using DTOLaye.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator: AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Fill the name");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Fill the surname");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Fill the mail address");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Fill the username");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Fill the password");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Repeat the password");
            RuleFor(x => x.Username).MaximumLength(20).WithMessage("Maximum characters for username is 20");
            RuleFor(x => x.Username).MinimumLength(5).WithMessage("Minimum characters for username is 5");
            RuleFor(x => x.Password).Equal(y=>y.ConfirmPassword).WithMessage("Passwords are not matched");
        }
    }
}
