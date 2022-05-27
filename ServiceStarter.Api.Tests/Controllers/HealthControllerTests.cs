using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceStarter.Contracts;
using ServiceStarter.Contracts.Health;
using ServiceStarter.Domain.Http;
using System.Net;
using System.Threading.Tasks;
using static ServiceStarter.Api.Tests.AssemblyInitialization;

namespace ServiceStarter.Api.Tests.Controllers
{
    [TestClass]
    public class HealthControllerTests
    {
        [TestMethod]
        public async Task HealthCheckAsync_Returns200OK()
        {
            // Arrange & Act
            var (response, check) = await Client.GetAsJsonWithResponseAsync<CheckResponse>($"{ApiRoutes.v1.Health}/check");

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.IsNotNull(check);
            Assert.IsTrue(check.ThumbsUp);
        }
    }
}
