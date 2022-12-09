using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail zorunlu alan.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Mail adresiniz hatali.");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Soyad zorunlu alan.");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj zorunlu alan.");
        }
    }
}
