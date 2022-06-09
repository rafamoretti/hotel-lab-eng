using System.Collections.Generic;
using Model;
using Model.Common;

namespace Queries.DataTransferObjects
{
    public class RoomData
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Cpf { get; set; }
        public int RoomNumber { get; set; }
        public RoomStatusEnum RoomStatus { get; set; }
    }
}