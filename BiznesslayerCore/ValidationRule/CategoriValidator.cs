using EntitylayerCore.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiznesslayerCore.ValidationRule
{
    public class CategoriValidator : AbstractValidator<Category>
    {
        public CategoriValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Başlıq hissəsini boş keçməyin");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Detayları boş keçməyin");
            RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage("Zəhmət olmasa 2-dən az hərf və yaxud simvol istifadə etməyin");
            RuleFor(x => x.CategoryName).MaximumLength(30).WithMessage("Zəhmət olmasa 30-dən artıq hərf və yaxud simvol istifadə etməyin");
            RuleFor(x => x.CategoryDescription).MinimumLength(30).WithMessage("Zəhmət olmasa 30-dən az hərf və yaxud simvol istifadə etməyin");
            RuleFor(x => x.CategoryDescription).MaximumLength(150).WithMessage("Zəhmət olmasa 150-dən artıq hərf və yaxud simvol istifadə etməyin");

        }
    }
}
