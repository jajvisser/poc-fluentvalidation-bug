using FluentValidation;

namespace ClientSideValidationTest.Models.NotWorking.Validators
{
    public class PersonsStepValidator : AbstractValidator<PersonsStepViewModel>
    {
        public PersonsStepValidator()
        {
            RuleFor(s => s.MainPerson)
                .SetValidator(new MainPersonValidator())
                .WithMessage("Test field validator");
        }
    }}