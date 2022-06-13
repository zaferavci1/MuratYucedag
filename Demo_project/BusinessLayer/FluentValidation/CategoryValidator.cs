using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        //FluentValidation ı kullnabailmek için Generic Constructor a ihtiyacım var
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategri ismi boş geçilemez");

        }
    }
}
