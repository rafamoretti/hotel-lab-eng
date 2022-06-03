using System.Collections.Generic;
using Model;
using Model.Common;

namespace Queries.DataTransferObjects
{
    public class GuestRoomDTO
    {
        public string GuestName { get; set; }
        public string GuestPhone { get; set; }
        public List<Product> Products { get; set; }
        public RoomStatusEnum RoomStatus { get; set; }
    }
}