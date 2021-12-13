using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using EmployeeAPI.Controller;
using Newtonsoft.Json;
using RestSharp;

namespace EmployeeAPI
{
    public class Program
    {
        
        static async Task Main(string[] args)
        {
            var employeeApi = new EmployeeRepository("http://51.148.170.137:9111/");
            EmployeeController employeeController = new EmployeeController(employeeApi);
            Console.WriteLine("Hello Wellcome!");
            //GetEmployees();
            employeeController.GetEmployee("4f43eb3e-cec8-4621-afeb-04447a28d695");
            //deleteEmployee("c3fa238e-91d4-4509-8645-b1dae0221f9e");
            //CreateEmployee();

        }
        
 

    }

}
