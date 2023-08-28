using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines.ValidationRules.FluentValidation
{
    public class ProductValidater:AbstractValidator<Product>
    {
        public ProductValidater()
        {
            RuleFor(p=>p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).Length(1, 30);


        }

    }
}
