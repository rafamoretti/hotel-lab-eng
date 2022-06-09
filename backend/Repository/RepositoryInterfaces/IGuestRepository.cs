using System;
using Model;

namespace Repository.RepositoryInterfaces
{
    public interface IGuestRepository : IDisposable
    {
        public void NewCheckIn(CheckIn checkIn);
        public void AddGuest(Guest guest);
        public Guest GetGuest(int id);
        public void Save();
    }
}