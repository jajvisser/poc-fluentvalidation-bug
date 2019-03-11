using ClientSideValidationTest.Models.Working.Validators;
using FluentValidation.Attributes;

namespace ClientSideValidationTest.Models.Working
{
    [Validator(typeof(MainPersonValidator))]
    public class MainPersonViewModel : PersonViewModel
    {
        public string Postcode { get; set; }

        public string Street { get; set; }
    }
}