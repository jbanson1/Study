using FluentValidation;
using System.Data;
using RotaAPI.Models;

namespace RotaAPI.Services.Validations.AssignmentValidations
{
    public class Delete : AbstractValidator<Assignment>
    {
        public Delete() 
        {
            RuleFor(x => x.id).NotNull()
                .WithMessage("");
            RuleFor(x => x.id).NotEmpty();
        }
    }
}
