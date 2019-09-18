using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        public StatusCodeResult Index() => StatusCode(StatusCodes.Status200OK);
        
        public ViewResult Result() => View((object)"Hello Master");

        public RedirectToActionResult Redirect() => RedirectToAction(nameof(Index));
    }
}
