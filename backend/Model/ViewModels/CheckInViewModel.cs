using System;
using System.ComponentModel.DataAnnotations;
using Model;
using Model.Common;

namespace ViewModels
{
    public class CheckInViewModel
    {
        public DateTime EndDate { get; set; }
        public AccommodationTypeEnum Type { get; set; }
        public Guest Guest { get; set; }
    }
}