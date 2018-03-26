using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Upstack_MVC_API;
using Upstack_MVC_API.Controllers;
using Upstack.DAL.Model;

namespace Upstack_MVC_API.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            IEnumerable<Person> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            List<Person> result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            ValuesController controller = new ValuesController();
            var person = new Person()
            {
                Id = 231,
                FirstName = "Test",
                LastName = "Test"
            };
            // Act
            controller.Post(person);

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            ValuesController controller = new ValuesController();
            var person = new Person()
            {
                Id = 231,
                FirstName = "Test",
                LastName = "Test"
            };
            // Act
            controller.Put(person);

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
