using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientSideValidationTest.Models.Working
{
    public abstract class StepViewModel
    {
        public string StepName { get; set; }
        public bool Active { get; set; }
    }
}