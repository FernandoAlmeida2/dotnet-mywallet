using dotnet_mywallet.Dtos.Record;
using FluentValidation;

namespace dotnet_mywallet.Middlewares.Record
{
    public class UpdateAmountValidator : AbstractValidator<UpdateAmountDto>
    {
        public UpdateAmountValidator()
        {
            RuleFor(p => p.Amount).GreaterThan(0).WithMessage("Amount must be greater than zero");
        }
    }
}