using System;
using Model.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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

        public int Id { get; set; }
        public int Number { get; set; }
        public RoomStatusEnum Status { get; set; } = RoomStatusEnum.Available;
        public IEnumerable<Product> Products { get; set; }
    }
}