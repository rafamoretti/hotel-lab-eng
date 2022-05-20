using System;
using Model;

namespace Repository.RepositoryInterfaces
{
    public interface IEmployeeRepository : IDisposable
    {
        public Employee GetEmployee(Guid employeeId);
        public void AddEmployee(Employee employee);
        public void UpdateEmployee(Employee employee);
        public void RemoveEmployee(Guid employeeId); 
        public void Save();
    }
}