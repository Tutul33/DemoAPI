using Sonali.API.Tests.DbFactory;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Sonali.API.Tests.IntegrationTests
{
    public class VoucherControllerIntegrationTests
        : IClassFixture<CustomWebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public VoucherControllerIntegrationTests(CustomWebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient(); // now works
        }

        [Fact]
        public async Task GetVoucherList_ReturnsSuccess()
        {
            var response = await _client.GetAsync("/api/Voucher/GetVoucherList");

            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();

            Assert.Contains("V001", content);
            Assert.Contains("V002", content);
        }
    }
}
