using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAPI.Controller
{
    public class EmployeeController
    {
        private readonly IRepository repository;
        public EmployeeController(IRepository repository)
        {
            this.repository = repository;
        }

        public List<EmployeeUser> GetEmployees() => repository.GetEmployees();
        public void GetEmployee(string id) => repository.GetEmployee(id);
        public void CreateEmployee(EmployeeUser employee) => repository.CreateEmployee(employee);
        public void DeleteEmployee(string id) => repository.DeleteEmployee(id);
        public void UpdateEmployee(int id, EmployeeUser employee) => repository.UpdateEmployee(id, employee);
    }
}
