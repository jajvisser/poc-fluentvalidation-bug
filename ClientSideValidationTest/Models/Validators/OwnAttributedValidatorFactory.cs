using System;
using ClientSideValidationTest.Models.NotWorking;
using FluentValidation;
using FluentValidation.Attributes;

namespace ClientSideValidationTest.Models.Validators
{
    public class OwnAttributedValidatorFactory : AttributedValidatorFactory
    {
        public override IValidator GetValidator(Type type)
        {
            var validatorType = type;
            if (validatorType.IsInterface)
            {
                validatorType = typeof(MainPersonViewModel);
            }
            return base.GetValidator(validatorType);
        }
    }
}