using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class DerivedController : Controller
    {
        public ViewResult Index()
        {
            return View("Result", $"This is a derived controller");
        }
    }
}
