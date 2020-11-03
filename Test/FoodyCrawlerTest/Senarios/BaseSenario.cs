using FoodyCrawler;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;
using Xunit;

namespace FoodyCrawlerTest.Senarios
{
    public class BaseSenario : IClassFixture<WebApplicationFactory<FoodyCrawler.Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public BaseSenario(WebApplicationFactory<FoodyCrawler.Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Get_EndpointsReturnSuccessAndCorrectContentType()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("");

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            Assert.Equal("text/html; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
        }
    }
}
