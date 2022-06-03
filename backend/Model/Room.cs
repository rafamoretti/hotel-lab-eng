using System;
using Model.Common;
using System.Collections.Generic;

namespace Model
{
    public class Room
    {
        public Room() {}

        public Room(int number, RoomStatusEnum status)
        {
            Number = number;
            Status = status;
        }

        public Guid Id { get; set; }
        public int Number { get; set; }
        public RoomStatusEnum Status { get; set; }
        public IEnumerable<Product> Products { get; set; }

        public Guest Guest { get; set; }
    }
}