using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class MovieValidator : AbstractValidator<Movie>
    {
        public MovieValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).Length(2, 100);
            RuleFor(p => p.CategoryId).GreaterThanOrEqualTo(1);
            RuleFor(p => p.Description).NotEmpty();
            RuleFor(p => p.Link).NotEmpty();
        }
         
    }
}
