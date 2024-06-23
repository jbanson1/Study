using FluentValidation;
using RotaAPI.Models;

namespace RotaAPI.Services.Validations.PersonValidations
{
    public class PersonPost : AbstractValidator<Person>
    {
        // Age of person of age to work
        // National Insurance
        // 
        public PersonPost(Person person)
        {
            RuleFor(x => x).NotNull()
                .WithMessage("");
            RuleFor(x => x.first_name).NotNull()
                .WithMessage("First Name requires a value");
            RuleFor(x => x.last_name).NotNull()
                .WithMessage("Last Name requires a value");
        }
    }
}
