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
            RuleFor(x => x.Name).NotEmpty().WithMessage("ürün Adını Boş Geçemezsiniz.");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Ürün En Az 3 karakter olmalıdır.");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stok Sayisi Boi Geçilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat boş geçilemez");
        }
    }
}
