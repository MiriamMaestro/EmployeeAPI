using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RestSharp;
using System.Net;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Mock<IRepository> repositoryStub = new();
        [TestMethod]
        public void TestMethod1()
        {
            var client = new RestClient("http://51.148.170.137:9111/");
            var request = new RestRequest("employee/{id}", Method.GET);
            //request.AddUrlSegment("{id}", "4f43eb3e-cec8-4621-afeb-04447a28d695");

            //var content = client.Execute(request).Content;

            // act
            IRestResponse response = client.Execute(request);

            // assert
            Assert.Equals(HttpStatusCode.OK, response.StatusCode);


        }
    }
}
