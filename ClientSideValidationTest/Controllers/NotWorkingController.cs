using System.Collections.Generic;
using System.Web.Mvc;
using ClientSideValidationTest.Models.NotWorking;

namespace ClientSideValidationTest.Controllers
{
    public class NotWorkingController : Controller
    {
        public ActionResult Index()
        {
            return View(new FlowModel { Steps = new List<StepViewModel> { new PersonsStepViewModel { StepName = "Invalid flow", Active = true } } });
        }
    }
}