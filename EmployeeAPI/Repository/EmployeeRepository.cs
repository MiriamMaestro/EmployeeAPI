using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;



namespace EmployeeAPI
{
    public class EmployeeRepository : IRepository
    {
        // private readonly RestClient client = new RestClient("http://51.148.170.137:9111/");
        private readonly RestClient client;
        public EmployeeRepository(string clientUrl)
        {
            client = new RestClient(clientUrl);
        }
        public List<EmployeeUser> GetEmployees()
        {
            var request = new RestRequest("employee");
            var response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = JsonConvert.DeserializeObject<List<EmployeeUser>>(response.Content);
                return result;
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }

        }
        public EmployeeUser GetEmployee(string id)
        {
            var request = new RestRequest("employee/" + id);
            var response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string rawResponse = response.Content;
                var result = JsonConvert.DeserializeObject<EmployeeUser>(rawResponse);
                return result;
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }
        }

        public void CreateEmployee(EmployeeUser employee)
        {
            var request = new RestRequest("employee", Method.POST);
            // request.AddJsonBody(new { name = "Miriam", startDate = "2021-03-18T00:00:00" });
            request.AddJsonBody(employee);
            var response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine("The Employee has added to the directory");
            }
        }
        public void DeleteEmployee(string id)
        {
            var request = new RestRequest("employee/" + id, Method.DELETE);
            var response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine("The Employee has been deleted");
            }
        }
        public void UpdateEmployee(int id, EmployeeUser employee)
        {
            var request = new RestRequest("employee/" + id, Method.PUT);
            request.AddJsonBody(employee);
            var response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine("The Employee has been Updated");
            }
        }
    }
}
