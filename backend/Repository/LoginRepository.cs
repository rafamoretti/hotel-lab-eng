using System;
using Model;
using AppConfig;
using Repository.RepositoryInterfaces;
using System.Linq;

namespace Repository
{
    public class LoginRepository : ILoginRepository, IDisposable
    {
        private bool disposed = false;
        private readonly AppDbContext _context;

        public LoginRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool GetEmployeeLogin(Employee employeeLogin)
        {
            var login = _context
                .Employees
                .Where(_ => 
                    _.Email == employeeLogin.Email && 
                    _.Password == employeeLogin.Password)
                .FirstOrDefault();
            
            if (login == null)
                return false;
            
            return true;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposed)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}