using FluentValidation;

namespace Ordering.Application.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderCommandValidation : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderCommandValidation()
        {
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
