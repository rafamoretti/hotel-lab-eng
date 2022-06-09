using System;
using System.Linq;
using AppConfig;
using Model;
using Repository.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class GuestRepository : IGuestRepository, IDisposable
    {
        private bool disposed = false;
        private readonly AppDbContext _context;
        private readonly IRoomRepository _roomRepository;

        public GuestRepository(AppDbContext context, IRoomRepository roomRepository)
        {
            _context = context;
            _roomRepository = roomRepository;
        }

        private CheckIn GetCheckin(int id)
        {
            var checkIn = _context
                .CheckIns
                .Where(_ => _.Id == id)
                .FirstOrDefault();

            return checkIn;
        }

        public void NewCheckIn(CheckIn checkIn)
        {
            checkIn.SetCost(checkIn.Type);
            checkIn.Guests.Room = LocateGuest();

            _context
                .CheckIns
                .Add(checkIn);
        }

        public Room LocateGuest()
        {
            var room = _roomRepository
                            .GetAvailableRoom();

            return room;
        }

        public void AddGuest(Guest guest)
        {   
            _context
                .Guests
                .Add(guest);  
        }
        
        public Guest GetGuest(int id)
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