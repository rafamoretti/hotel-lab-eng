using System;
using System.Collections.Generic;
using Model;
using Model.Common;

namespace ViewModels
{
    public class RoomViewModel
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public RoomStatusEnum Status { get; set; }
    }
}