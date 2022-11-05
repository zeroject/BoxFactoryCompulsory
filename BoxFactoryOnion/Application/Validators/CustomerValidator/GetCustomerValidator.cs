using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using FluentValidation;

namespace Application.Validators.CustomerValidator
{
    public class GetCustomerValidator : AbstractValidator<GetCustomerDTO>
    {
        public GetCustomerValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.CompanyName).NotEmpty();
        }
    }
}
