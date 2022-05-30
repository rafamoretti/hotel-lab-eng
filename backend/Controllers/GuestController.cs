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
            [FromBody] CheckInViewModel checkIn
        )
        {
            if (checkIn == null)
                return BadRequest();

            var guestCheckIn = _classReader
                .ClassMapper<CheckIn, CheckInViewModel>(checkIn);

            if (guestCheckIn == null)
                return BadRequest();

            _guestRepository
                .NewCheckIn(guestCheckIn);

            _guestRepository
                .Save();

            return Ok(); 
        }
    }
}