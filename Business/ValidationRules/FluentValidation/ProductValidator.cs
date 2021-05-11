using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
            RuleFor(p => p.ProductName).Must(StardWithA).WithMessage("Ürünler A harfi ile başlamalıdır");// kendi metodumuzu böyle yazıyoruz


        }

        private bool StardWithA(string arg)// true ise kurala uygun false ise uygun değil
        {
            return arg.StartsWith("A");
        }
    }
}
