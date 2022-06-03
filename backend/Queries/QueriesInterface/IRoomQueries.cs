using System;
using System.Collections.Generic;
using Queries.DataTransferObjects;

namespace Queries.QueriesInterface
{
    public interface IRoomQueries
    {
        public List<GuestRoomDTO> GetGuestRoom(Guid id); 
        public List<T> ExecuteQuery<T>(string query);
    }
}