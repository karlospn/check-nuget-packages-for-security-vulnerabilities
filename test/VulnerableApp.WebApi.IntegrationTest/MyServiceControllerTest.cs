using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using VulnerableApp.Library.Contracts.Dto;
using VulnerableApp.WebApi.IntegrationTest.Helper;
using Xunit;

namespace VulnerableApp.WebApi.IntegrationTest
{
    public class MyServiceControllerTest: IClassFixture<WebApplicationTest>
    {
        private readonly HttpClient _client;

        public MyServiceControllerTest(WebApplicationTest applicationTest)
        {
            _client = applicationTest.CreateDefaultClient();
        }


        [Fact]
        public async Task CreateNewFooData_ReturnOk()
        {
            var request = new FooRqDto()
            {
                Data = "TestData",
                Color = Color.Green
            };
            var response = await _client.PostAsJsonAsync("/v1/MyService",request);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}