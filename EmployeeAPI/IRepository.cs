using System.Collections.Generic;
using static EmployeeAPI.EmployeeRepository;

namespace EmployeeAPI
{
    public interface IRepository
    {
        void DeleteEmployee(string id);
        EmployeeUser GetEmployee(string id);
        List<EmployeeUser> GetEmployees();
        void UpdateEmployee(int id, EmployeeUser employee);
    }
}