using dotnet_mywallet.Dtos.Record;
using dotnet_mywallet.Models;
using FluentValidation;

namespace dotnet_mywallet.Middlewares.Record
{
    public class SaveRecordValidator : AbstractValidator<SaveRecordReqDto>
    {
        public SaveRecordValidator()
        {
            RuleFor(p => p.Amount).GreaterThan(0).WithMessage("Amount must be greater than zero");
            RuleFor(p => p.Type).IsInEnum().WithMessage("Type must be Income or Expense");
            RuleFor(p => p.Description).NotEmpty().WithMessage("Required field! (Not empty)");
        }
    }
}