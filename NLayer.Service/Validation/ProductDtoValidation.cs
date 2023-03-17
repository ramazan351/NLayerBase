using FluentValidation;
using NLayer.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Validation
{
    public class ProductDtoValidation:AbstractValidator<ProductDto>
    {
        public ProductDtoValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.Name).Length(2, 50).WithMessage("Name must be between 2 and 50 characters");
            RuleFor(x => x.Price).InclusiveBetween(1, int.MaxValue).WithMessage("Price must be greater than 0");
            RuleFor(x => x.CategoryId).InclusiveBetween(1, int.MaxValue).WithMessage("CategoryId must be greater than 0");

        }
    }
}
