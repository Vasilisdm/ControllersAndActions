using Microsoft.AspNetCore.Mvc;
using System;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Message = "Hello Master";
            ViewBag.Date = DateTime.Now;
            return View();
        }

        public ViewResult Result() => View((object)"Hello Master");

        public RedirectResult Redirect() => Redirect("/Example/Index");

        public RedirectToRouteResult Redirect() =>
            RedirectToRoute(new
            {
                controller = "Example",
                action = "Index",
                Id = "MyID"
            });
    }
}
