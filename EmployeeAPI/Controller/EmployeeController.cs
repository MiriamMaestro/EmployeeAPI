using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAPI.Controller
{
    public class EmployeeController
    {

        static EmployeeRepository employeeRepository = new EmployeeRepository();
        public static void GetEmployees() => employeeRepository.GetEmployees();
        public static void GetEmployee(string id) => employeeRepository.GetEmployee(id);
        public static void CreateEmployee(EmployeeRepository.EmployeeUser employee) => EmployeeRepository.CreateEmployee(employee);
        public static void DeleteEmployee(string id) => employeeRepository.DeleteEmployee(id);
        public static void UpdateEmployee(int id, EmployeeRepository.EmployeeUser employee) => employeeRepository.UpdateEmployee(id, employee);
    }
}
