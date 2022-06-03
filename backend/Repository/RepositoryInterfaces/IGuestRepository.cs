using System;
using Model;

namespace Repository.RepositoryInterfaces
{
    public interface IGuestRepository : IDisposable
    {
        public void NewCheckIn(CheckIn checkIn);
        public Guest GetGuest(Guid id);
        public void Save();
    }
}