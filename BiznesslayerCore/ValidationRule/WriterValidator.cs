using EntitylayerCore.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiznesslayerCore.ValidationRule
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Ad soyad hissəsini boş keçməyin");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adres hissəsini boş keçməyin");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifrə hissəsini boş keçməyin");
            RuleFor(x => x.WriterImage).NotEmpty().WithMessage("Şəkil  hissəsini boş keçməyin");
            //RuleFor(x => x.WriterPassword).Equal(y => y.WriterPassword).WithMessage("Şifrələr uyğun deyil");
        }
    }
}
