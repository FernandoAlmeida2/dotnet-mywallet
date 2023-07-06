using dotnet_mywallet.Dtos.User;
using FluentValidation;

namespace dotnet_mywallet.Middlewares.User
{
    public class UserLoginValidator : AbstractValidator<UserLoginDto>
    {
       public UserLoginValidator()
       {
            RuleFor(p => p.Email).EmailAddress().WithMessage("Provide a valid email!");
       }
    }
}