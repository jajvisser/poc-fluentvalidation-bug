using ClientSideValidationTest.Models.NotWorking.Validators;
using FluentValidation.Attributes;

namespace ClientSideValidationTest.Models.NotWorking
{
    [Validator(typeof(PersonsStepValidator))]
    public class PersonsStepViewModel : StepViewModel
    {
        public MainPersonViewModel MainPerson { get; set; }
        public PersonViewModel Partner { get; set; }
    }
}