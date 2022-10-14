using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using FluentValidation;

namespace Application.Validators.BoxValidator
{
    public class GetBoxValidator : AbstractValidator<GetBoxDTO>
    {
        public GetBoxValidator()
        {
            RuleFor(p => p.BoxName).NotEmpty();
            RuleFor(p => p.Price).GreaterThan(0);
        }
    }
}
