using Microsoft.AspNetCore.Mvc;
using System;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        public ContentResult Index() => Content("[\"Bill\", \"George\", \"Kostas\" ]", "application/json");
        
        public ViewResult Result() => View((object)"Hello Master");

        public RedirectToActionResult Redirect() => RedirectToAction(nameof(Index));
    }
}
