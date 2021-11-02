using System;
using System.Net;
using System.Net.Http;
using Xunit;

namespace TestRestAPI
{
    public class UnitTest1
    {
        public class TestClientProvider
        {
            public HttpClient Client { get; private set; }

            public TestClientProvider()
            {
                var server = new TestServer(new WebHostBuilder().UseStartup());

                Client = server.CreateClient();
            }
        }
        [Fact]
        public void Test1()
        {
            using (var client = new TestClientProvider().Client)
            {
                var response = await client.GetAsync("/api/employee");

                response.EnsureSuccessStatusCode();

                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            }

        }
    }
}
