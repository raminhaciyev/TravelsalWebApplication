using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Fill the name");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Fill the description");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Maximum character for name is 30");
            RuleFor(x => x.Description).MinimumLength(10).WithMessage("Minimum character for description is 10");
        }
    }
}
