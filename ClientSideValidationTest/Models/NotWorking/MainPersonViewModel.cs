using ClientSideValidationTest.Models.NotWorking.Validators;
using FluentValidation.Attributes;

namespace ClientSideValidationTest.Models.NotWorking
{
    [Validator(typeof(MainPersonValidator))]
    public class MainPersonViewModel : PersonViewModel, IAddress
    {
        public string Postcode { get; set; }

        public string Street { get; set; }
    }
}