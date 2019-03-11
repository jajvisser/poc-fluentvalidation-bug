using ClientSideValidationTest.Models.Validators;
using FluentValidation;

namespace ClientSideValidationTest.Models.Working.Validators
{
    public class MainPersonValidator : AbstractValidator<MainPersonViewModel>
    {
        public MainPersonValidator()
        {
            RuleFor(s => s.Postcode).SetValidator(new PostcodeValidator());
        }
    }
}