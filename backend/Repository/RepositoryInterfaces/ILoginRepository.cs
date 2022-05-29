using System;
using Model;

namespace Repository.RepositoryInterfaces
{
    public interface ILoginRepository : IDisposable
    {
        public bool GetEmployeeLogin(Employee employeeLogin);
    }
}