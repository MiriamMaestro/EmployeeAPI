using EmployeeAPI;
using EmployeeAPI.Controller;
using FluentAssertions;
using Moq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using Xunit;

namespace EmployeeAPITest
{
    public class UnitTest1
    {
        private readonly Mock<IRepository> repositoryStub = new();
        private readonly Random rand = new();

        [Fact]
        public void GetEmployees_WhenExistingItem_ReturnAllEmployees()
        {
            
            List<EmployeeUser> expectedEmployees = new List<EmployeeUser> { CreateRandomItem(), CreateRandomItem(), CreateRandomItem() };
            
            repositoryStub.Setup(repo => repo.GetEmployees())
               .Returns(expectedEmployees);

            var controller = new EmployeeController(repositoryStub.Object);
            List<EmployeeUser> result = controller.GetEmployees();

            expectedEmployees.Should().BeEquivalentTo(result);

        }
        [Fact]
        public void GetEmployees_WhenUnExistingItem_ReturnError()
        {

            repositoryStub.Setup(repo => repo.GetEmployees())
               .Returns((List<EmployeeUser>)null);

            var controller = new EmployeeController(repositoryStub.Object);
            List<EmployeeUser> result = controller.GetEmployees();

            result.Should().Throw<ArgumentNullException>()
                .WithParameterName("message"); ;

        }
        private EmployeeUser CreateRandomItem()
        {
            return new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = Guid.NewGuid().ToString(),
                CreatedDate = DateTime.Now
            };
        }
    }
}

