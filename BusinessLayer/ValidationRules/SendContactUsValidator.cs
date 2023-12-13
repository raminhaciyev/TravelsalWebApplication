using DTOLaye.DTOs.AnnouncementDTOs;
using DTOLaye.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SendContactUsValidator : AbstractValidator<SendMessageDto>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Type your mail address");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Type your subject");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Type your name");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Type your message");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Minimum 3 characters");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Maximum 50 characters");
            RuleFor(x => x.MessageBody).MaximumLength(3).WithMessage("Maximum 50 characters");
            RuleFor(x => x.MessageBody).MaximumLength(100).WithMessage("Maximum 100 characters");
        }
    }
}
