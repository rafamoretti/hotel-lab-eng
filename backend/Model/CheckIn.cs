using System;
using System.Collections.Generic;
using Model.Common;

namespace Model
{
    public class CheckIn
    {
        public CheckIn() {}

        public CheckIn (DateTime startDate, DateTime endDate, AccommodationTypeEnum type, double cost)
        {
            StartDate = startDate;
            EndDate = endDate;
            Type = type;
            Cost = cost;
        }

        public int Id { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; }
        public AccommodationTypeEnum Type { get; set; }
        public double Cost { get; private set; }

        public Guest Guests { get; set; }

        public void SetCost(AccommodationTypeEnum type)
        {
            Cost = (1200 * (int)type) + 1200;
        }
    }
}