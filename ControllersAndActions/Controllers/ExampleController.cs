using Microsoft.AspNetCore.Mvc;
using System;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        public VirtualFileResult Index() => File("/lib/bootstrap/dist/css/bootstrap.css", "text/css");
        
        public ViewResult Result() => View((object)"Hello Master");

        public RedirectToActionResult Redirect() => RedirectToAction(nameof(Index));
    }
}
