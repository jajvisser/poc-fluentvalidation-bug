using System.Collections.Generic;
using System.Web.Mvc;
using FluentValidation.Internal;
using FluentValidation.Mvc;
using FluentValidation.Validators;

namespace ClientSideValidationTest.Models.Validators
{
    public class PostcodeFieldClientFieldValidator : FluentValidationPropertyValidator
    {
        public PostcodeFieldClientFieldValidator(ModelMetadata metadata, ControllerContext controllerContext, PropertyRule rule,
            IPropertyValidator validator) : base(metadata, controllerContext, rule, validator)
        {
        }

        public override IEnumerable<ModelClientValidationRule> GetClientValidationRules()
        {
            yield return new ModelClientValidationRule
            {
                ErrorMessage = "Error!",
                ValidationType = "postcode"
            };
        }
    }
}