using System;
using System.Linq;
using AppConfig;
using Model;
using Repository.RepositoryInterfaces;

namespace Repository
{
    public class GuestRepository : IGuestRepository, IDisposable
    {
        private bool disposed = false;
        private readonly AppDbContext _context;

        public GuestRepository(AppDbContext context)
        {
            _context = context;
        }

        public void NewCheckIn(CheckIn checkIn)
        {
            checkIn.SetCost(checkIn.Type);
            
            _context
                .CheckIns
                .Add(checkIn);  
        }
        
        public Guest GetGuest(Guid id)
        {
            return _context
                        .Guests
                        .Where(_ => _.Id == id)
                        .FirstOrDefault();
        }

        public void Save()
        {
            _context
                .SaveChanges();
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