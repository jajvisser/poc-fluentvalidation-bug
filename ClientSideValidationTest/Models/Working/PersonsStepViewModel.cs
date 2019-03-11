using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientSideValidationTest.Models.Working
{
    public class PersonsStepViewModel : StepViewModel
    {
        public MainPersonViewModel MainPerson { get; set; }
        public PersonViewModel Partner { get; set; }
    }
}