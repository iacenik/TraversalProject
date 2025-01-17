﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidatior:AbstractValidator<About>
    {
        public AboutValidatior()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz....!");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen Görsel Seçiniz");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen en az 50 karakterlik açıklama bilgisi giriniz...!");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Lütfen açıklamayı kısaltınız....!");
        }

    }
}
