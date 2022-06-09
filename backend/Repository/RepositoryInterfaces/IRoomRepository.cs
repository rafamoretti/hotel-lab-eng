using Model;
using Model.Common;
using System;
using System.Linq;

namespace Repository.RepositoryInterfaces
{
    public interface IRoomRepository
    {
        public Room GetAvailableRoom();
        public void UpdateStatus(int id, RoomStatusEnum status);
        public void Save();
    }
}