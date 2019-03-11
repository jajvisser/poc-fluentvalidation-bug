using System.Collections.Generic;
using System.Linq;

namespace ClientSideValidationTest.Models.NotWorking
{
    public class FlowModel
    {
        public List<StepViewModel> Steps { get; set; }

        public StepViewModel ActiveStep
        {
            get { return Steps.FirstOrDefault(s => s.Active); }
        }
    }
}