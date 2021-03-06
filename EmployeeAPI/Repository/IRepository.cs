using System.Collections.Generic;

namespace EmployeeAPI
{
    public interface IRepository
    {
        void DeleteEmployee(string id);
        EmployeeUser GetEmployee(string id);
        List<EmployeeUser> GetEmployees();
        void UpdateEmployee(int id, EmployeeUser employee);
        void CreateEmployee(EmployeeUser employee);
    }
}