using Microsoft.AspNetCore.Mvc;
using System;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        public JsonResult Index() => Json(new[] { "Bill", "George", "Kostas" });
        
        public ViewResult Result() => View((object)"Hello Master");

        public RedirectToActionResult Redirect() => RedirectToAction(nameof(Index));
    }
}
