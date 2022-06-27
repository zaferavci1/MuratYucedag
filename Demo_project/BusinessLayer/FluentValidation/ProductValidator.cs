using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3).WithMessage("ürün Adını Boş Geçemezsiniz.Ürün En Az 3 karakter olmalıdır.");
            RuleFor(x => x.Stock).NotEmpty().LessThan(1000).WithMessage("Stok Sayisi Boş Geçilemez.Stok 1000' den az olmalı.");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat boş geçilemez");
        }
    }
}
