using System.Collections.Generic;
using System.Web.Mvc;
using ClientSideValidationTest.Models.Working;

namespace ClientSideValidationTest.Controllers
{
    public class WorkingController : Controller
    {
        public ActionResult Index()
        {
            return View(new FlowModel { Steps = new List<StepViewModel> { new PersonsStepViewModel { StepName = "Invalid flow", Active = true } } });
        }
    }
}