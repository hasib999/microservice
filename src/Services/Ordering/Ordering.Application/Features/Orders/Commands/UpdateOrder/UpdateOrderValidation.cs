using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Features.Orders.Commands.UpdateOrder
{
    public class UpdateOrderValidation:AbstractValidator<UpdateOrderCommand>
    {
        public UpdateOrderValidation()
        {
            RuleFor(p => p.Id)
                .GreaterThan(0).WithMessage("Please enter order id");
            RuleFor(p => p.UserName)
                .NotEmpty().WithMessage("{UserName} is required.")
                .NotNull()
                .EmailAddress().WithMessage("{UserName} should be valid email.");
            RuleFor(p => p.EmailAddress)
                    .EmailAddress().WithMessage("{EmailAddress} should be valid email.");
            RuleFor(p => p.FirstName)
                    .NotEmpty().WithMessage("{FirstName} is required.")
                    .MaximumLength(100).WithMessage("First name must not exceed 100 characters.");
            RuleFor(p => p.TotalPrice).GreaterThan(0).WithMessage("{TotalPrice} should be greater than zero.");
        }
    }
}
