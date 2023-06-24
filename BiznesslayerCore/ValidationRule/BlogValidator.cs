using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitylayerCore.Concrete;
using FluentValidation;

namespace BiznesslayerCore.ValidationRule
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Başlıq hissəsini boş keçməyin");
            RuleFor(x => x.CategoryID).NotEmpty().WithMessage("Boş keçməyin");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog Detayları boş keçməyin");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Şəkil hissəsini boş keçməyin");
            RuleFor(x => x.BlogThumbnailImage).NotEmpty().WithMessage("Şəkil  hissəsini boş keçməyin");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Zəhmət olmasa 150-dən artıq hərf və yaxud simvol istifadə etməyin");
            RuleFor(x => x.BlogContent).MinimumLength(300).WithMessage("Zəhmət olmasa 800-dən az hərf və yaxud simvol istifadə etməyin");
        }
    }
}
