using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTask2.Controllers;

namespace TestTask2.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
