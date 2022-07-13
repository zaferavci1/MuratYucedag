﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3).WithMessage("Kullanıcı ismi boş geçilemez ve 3 karakterden küçük olamaz");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir bölümü boş geçilemez");
        }
    }
}
