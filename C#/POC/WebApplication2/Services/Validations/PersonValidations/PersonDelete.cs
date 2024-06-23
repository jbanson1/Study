using FluentValidation;
using RotaAPI.Models;

namespace RotaAPI.Services.Validations.PersonValidations
{
    public class PersonDelete : AbstractValidator<Person>
    {
        public PersonDelete()
        {
            RuleFor(x => x.first_name)
                .Must(x => (x) != null)
                .WithMessage("First Name requires a value");


        }
    }
}
