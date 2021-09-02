using FluentValidation;
using MemberRegistration.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistiration.Business.ValidationRules.FluentValidation
{
    public class MemberValidator : AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(m => m.FirstName).NotEmpty().WithMessage("Kullanıcı adi boş olamaz");
            RuleFor(m => m.LastName).NotEmpty().WithMessage("Soyadi boş olamaz");
            RuleFor(m => m.TcNo).NotEmpty().WithMessage("Tc Kimlik boş olamaz").Length(11).WithMessage("Tc Kimlik 11 karakter den az olamaz");
            RuleFor(m => m.Email).NotEmpty().WithMessage("Email boş olamaz").EmailAddress();
            RuleFor(m => m.DateOfBirth).NotEmpty().WithMessage("Doğum Tarihi Boş Olmaz");
            RuleFor(m => m.DateOfBirth).LessThan(DateTime.Now).WithMessage("Doğum Tarihi Şimdiden Küçük Olmalı"); ;
        }
    }
}
