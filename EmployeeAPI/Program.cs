using System;
using System.Collections.Generic;
using System.Net;
using EmployeeAPI.Controller;
using Newtonsoft.Json;
using RestSharp;

namespace EmployeeAPI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Wellcome!");
           //GetEmployees();
            
            GetEmployee("4f43eb3e-cec8-4621-afeb-04447a28d695");
            //deleteEmployee("c3fa238e-91d4-4509-8645-b1dae0221f9e");
            //CreateEmployee();

        }
        EmployeeController employeeController = new EmployeeController();
        static EmployeeRepository employeeRepository = new EmployeeRepository();
        public static void GetEmployees() => employeeRepository.GetEmployees();
        public static void GetEmployee(string id) => employeeRepository.GetEmployee(id);
        public static void CreateEmployee(EmployeeRepository.EmployeeUser employee) => EmployeeRepository.CreateEmployee(employee);
        public static void DeleteEmployee(string id) => employeeRepository.DeleteEmployee(id);
        public static void UpdateEmployee(int id, EmployeeRepository.EmployeeUser employee) => employeeRepository.UpdateEmployee(id, employee);

    }

}
