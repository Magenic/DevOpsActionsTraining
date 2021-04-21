using Magenic.Maqs.BaseWebServiceTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

namespace Tests
{
    /// <summary>
    /// Sample test class
    /// </summary>
    [TestClass]
    public class WebServiceTests : BaseWebServiceTest
    {
        /// <summary>
        /// Check if the contact page is up
        /// </summary>
        [TestMethod]
        public void IsContactUp()
        {
            var result = this.WebServiceDriver.GetWithResponse("Home/Contact", "text/html", false);

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode, "Expected OK");
        }

        /// <summary>
        /// Check if the about page is up
        /// </summary>
        [TestMethod]
        public void IsAboutUp()
        {
            var result = this.WebServiceDriver.GetWithResponse("Home/About", "text/html", false);

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode, "Expected OK");
        }
        /// <summary>
        /// Check if the home page is up
        /// </summary>
        [TestMethod]
        public void IsHomeUp()
        {
            var result = this.WebServiceDriver.GetWithResponse("", "text/html", false);

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode, "Expected OK");
        }
    }
}
