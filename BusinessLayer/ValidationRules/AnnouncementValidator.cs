using DTOLaye.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class AnnouncementValidator: AbstractValidator<AnnouncementAddDto>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Fill the title");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Fill the content");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Minimum character is 3");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("Minimum character is 20");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Maximum character is 50");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Maximum character is 500");
        }
    }
}
