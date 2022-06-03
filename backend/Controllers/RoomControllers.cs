using System;
using Microsoft.AspNetCore.Mvc;
using Repository.RepositoryInterfaces;

namespace Controllers
{
    [ApiController]
    public class RoomControllers : ControllerBase
    {
        private readonly IGuestRepository _guestRepository;

        public RoomControllers(IGuestRepository guestRepository)
        {
            _guestRepository = guestRepository;
        }

        
    }
}