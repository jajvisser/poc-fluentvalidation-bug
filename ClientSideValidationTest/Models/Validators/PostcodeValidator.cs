using FluentValidation.Validators;

namespace ClientSideValidationTest.Models.Validators
{
    public class PostcodeValidator : PropertyValidator
    {
        protected override bool IsValid(PropertyValidatorContext context)
        {
            var postcode = context.PropertyValue as string;
            return postcode?.Length == 6;
        }

        public PostcodeValidator() : base("This is FieldValidator")
        {
        }
    }
}