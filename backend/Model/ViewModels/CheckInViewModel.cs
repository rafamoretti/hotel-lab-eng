using System;
using System.ComponentModel.DataAnnotations;
using Model.Common;

namespace ViewModels
{
    public class CheckInViewModel
    {
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public AccommodationTypeEnum Type { get; set; }
    }
}