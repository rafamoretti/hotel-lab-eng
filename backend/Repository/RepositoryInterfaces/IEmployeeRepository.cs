using System;
using Model;

namespace Repository.RepositoryInterfaces
{
    public interface IEmployeeRepository : IDisposable
    {
        public Employee GetEmployee(int employeeId);
        public void AddEmployee(Employee employee);
        public void UpdateEmployee(Employee employee);
        public void RemoveEmployee(int employeeId); 
        public void Save();
    }
}