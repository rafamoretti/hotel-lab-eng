using System;
using Assets;
using Microsoft.AspNetCore.Mvc;
using Model;
using Repository.RepositoryInterfaces;
using ViewModels;

namespace Controllers
{
    [ApiController]
    [Route("v1")]
    public class GuestController : ControllerBase
    {
        private readonly IGuestRepository _guestRepository;
        private readonly IClassReader _classReader;

        public GuestController(IGuestRepository guestRepository, IClassReader classReader)
        {
            _guestRepository = guestRepository;
            _classReader = classReader;
        }

        [HttpPost]
        [Route("checkin")]
        public IActionResult AddCheckIn(
            [FromBody] CheckIn checkIn
        )
        {
            if (checkIn == null)
                return BadRequest();

            _guestRepository
                .NewCheckIn(checkIn);

            _guestRepository
                .Save();

            return Ok(); 
        }

        [HttpGet]
        [Route("employee/{id}")]
        public IActionResult GetGuestInfo(
            [FromRoute] int id
        )
        {
            var guestInfo = _guestRepository
                                .GetGuest(id);

            if (guestInfo != null)
                return Ok(guestInfo);

            return BadRequest();
        }
    }
}