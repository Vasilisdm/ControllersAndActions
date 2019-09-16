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
    }
}
