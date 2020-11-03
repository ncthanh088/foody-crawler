using FoodyCrawlerTest.Infrastructure;
using FoodyCrawlerTest.TestServer;
using Xunit;

namespace FoodyCrawlerTest.Senarios
{
    public class FoodyServiceSenario : IClassFixture<CustomWebApplicationFactory<StartupTest>>
    { 
        private readonly CustomWebApplicationFactory<StartupTest> _factory;

        public FoodyServiceSenario(CustomWebApplicationFactory<StartupTest> factory)
        {
            _factory = factory;            

        }

        [Fact]
        public void SyncMasterData_ShouldSuccess()
        {
            
        }
    }
}
