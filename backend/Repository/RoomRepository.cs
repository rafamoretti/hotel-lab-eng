using AppConfig;
using Repository.RepositoryInterfaces;
using System;
using Model.Common;
using Model;
using System.Linq;

namespace Repository
{
    public class RoomRepository : IRoomRepository
    {
        private readonly AppDbContext _context;

        public RoomRepository(AppDbContext context)
        {
            _context = context;
        }

        public Room GetAvailableRoom()
        {
            var availableRoom = _context
                                    .Rooms
                                    .Where(_ => _.Status == RoomStatusEnum.Available)
                                    .First();

            return availableRoom;
        }

        public void UpdateStatus(int id, RoomStatusEnum status)
        {
            var room = _context
                        .Rooms
                        .FirstOrDefault(_ => _.Id == id);

            room.Status = status;

            _context
                .Update(room);
        }
       
        public void Save()
        {
            _context
                .SaveChanges();
        }
    }
}