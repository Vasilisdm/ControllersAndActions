using ControllersAndActions.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace ControllersAndActions.Tests
{
    public class ActionTests
    {
        [Fact]
        public void ViewSelected()
        {
            //Arrange
            HomeController cntrl = new HomeController();

            //Act
            ViewResult result = cntrl.ReceiveForm("Adam", "London");

            //Assert
            Assert.Equal("Result", result.ViewName);
        }

        [Fact]
        public void ModelObjectType()
        {
            //Arrange
            ExampleController cntrl = new ExampleController();

            //Act
            ViewResult result = cntrl.Index();

            //Assert
            Assert.IsType<string>(result.ViewData["Message"]);
            Assert.Equal("Hello Master", result.ViewData["Message"]);
            Assert.IsType<DateTime>(result.ViewData["Date"]);
        }

        [Fact]
        public void Redirection()
        {
            //Arrange
            ExampleController cntrl = new ExampleController();

            //Act
            RedirectToRouteResult result = cntrl.Redirect();

            //Assert
            Assert.False(result.Permanent);
            Assert.Equal("Example", result.RouteValues["controller"]);
            Assert.Equal("Index", result.RouteValues["action"]);
            Assert.Equal("MyID", result.RouteValues["Id"]);
        }
    }
}
