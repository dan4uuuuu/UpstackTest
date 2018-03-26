using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Upstack_MVC_API;
using Upstack_MVC_API.Controllers;

namespace Upstack_MVC_API.Tests.Controllers
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
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
