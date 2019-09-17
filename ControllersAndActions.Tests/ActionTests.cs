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
            RedirectToActionResult result = cntrl.Redirect();

            //Assert
            Assert.False(result.Permanent);
            Assert.Equal("Index", result.ActionName);
        }

        [Fact]
        public void JsonActionMethod()
        {
            // Arrange
            ExampleController cntrl = new ExampleController();

            // Act
            JsonResult result = cntrl.Index();

            // Assert
            Assert.Equal(new[] { "Bill", "George", "Kostas" }, result.Value);
        }
    }
}
