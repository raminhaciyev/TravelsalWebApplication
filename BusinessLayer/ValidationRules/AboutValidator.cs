using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AbstractValidator : AbstractValidator<About>
    {
        public AbstractValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Fill the gaps..");
            RuleFor(x => x.Title).MinimumLength(50).WithMessage("Use at least 50 characters");
        }
    }
}
