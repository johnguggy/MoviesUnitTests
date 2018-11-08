using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStore.Web;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieStore.Web.Controllers;
using System.Web.Mvc;

namespace MovieStore.Tests
{
    [TestClass]
    public class MoviesTablesControllerTest
    {
        [TestMethod]
        public void TestIndexRedirect()
        {
            var controller = new MoviesTablesController();
            var result = (RedirectToRouteResult)controller.Details(-1);
            Assert.AreEqual("Index", result.RouteValues["action"]);

        }

        [TestMethod]
        public void GetCreatePass()
        {
            // Arrange
            var tc = new MoviesTablesController();

            // Act
            var test = tc.Create("List is good");

            // Assert
            Assert.IsNotNull(test, "Not Null");
        }

        [TestMethod]
        public void TestDetailsRedirect()
        {
            var controller = new MoviesTablesController();
            var result = (RedirectToRouteResult)controller.Details(-1);
            Assert.AreEqual("Index", result.RouteValues["action"]);

        }
        [TestMethod]
        public void TestCartRedirect()
        {
            var controller = new MoviesTablesController();
            var result = (RedirectToRouteResult)controller.Details(-1);
            Assert.AreEqual("Index", result.RouteValues["action"]);

        }
        [TestMethod]
        public void TestDeleteRedirect()
        {
            var controller = new MoviesTablesController();
            var result = (RedirectToRouteResult)controller.Details(-1);
            Assert.AreEqual("Index", result.RouteValues["action"]);

        }
        [TestMethod]
        public void TestEditRedirect()
        {
            var controller = new MoviesTablesController();
            var result = (RedirectToRouteResult)controller.Details(-1);
            Assert.AreEqual("Index", result.RouteValues["action"]);

        }
    }
}
