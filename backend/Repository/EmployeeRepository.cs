using System;
using Model;
using AppConfig;
using Repository.RepositoryInterfaces;
using System.Linq;

namespace Repository
{
    public class EmployeeRepository : IEmployeeRepository, IDisposable
    {
        private bool disposed = false;
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public Employee GetEmployee(Guid employeeId)
        {
            return _context
                    .Employees
                    .FirstOrDefault(_ => _.Id == employeeId);
        }

        public void AddEmployee(Employee employee)
        {
            _context
                .Employees
                .Add(employee);
        }

        public void RemoveEmployee(Guid employeeId)
        {
            var employee = _context
                            .Employees
                            .Find(employeeId);

            _context
                .Employees
                .Remove(employee);
                
        }

        public void UpdateEmployee(Employee employee)
        {
            _context
                .Update(employee);
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

        public void Save()
        {
            _context
                .SaveChanges();
        }
    }
}