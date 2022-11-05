using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using FluentValidation;

namespace Application.Validators.OrderValidator
{
    public class GetOrderValidator : AbstractValidator<GetOrderDTO>
    {
        public GetOrderValidator()
        {
            RuleFor(p => p.StatusCode).NotEmpty();
            RuleFor(p => p.DateTime).NotNull();
        }
    }
}
