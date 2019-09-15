using ControllersAndActions.Controllers;
using Microsoft.AspNetCore.Mvc;
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
    }
}
