using gAutomotive.WebApi.Tests.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;

namespace gAutomotive.WebApi.Tests.ControllerTests
{
    [TestClass]
    public class Customers
    {
        static Customers()
        {
            Url.Set(ProjectType.Local);
        }

        [TestMethod]
        public void GetAllCustomersTest()
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync(Url.GetAllCustomersUrl).Result;
            string result = response.Content.ReadAsStringAsync().Result;
            Assert.IsNotNull(result);
        }
    }
}
