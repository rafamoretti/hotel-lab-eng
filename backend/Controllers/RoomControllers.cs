using System;
using Assets;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.Common;
using Queries.QueriesInterface;
using Repository.RepositoryInterfaces;
using ViewModels;

namespace Controllers
{
    [ApiController]
    [Route("v1")]
    public class RoomControllers : ControllerBase
    {
        private readonly IGuestRepository _guestRepository;
        private readonly IRoomRepository _roomRepository;
        private readonly IRoomQueries _roomQueries;
        private readonly IClassReader _classReader;

        public RoomControllers(IGuestRepository guestRepository, IRoomRepository roomRepository, IRoomQueries roomQueries, IClassReader classReader)
        {
            _guestRepository = guestRepository;
            _roomRepository = roomRepository;
            _roomQueries = roomQueries;
            _classReader = classReader;
        }

        [HttpGet]
        [Route("guest/room/{id}")]
        public IActionResult GetGuestRoomInfo(
            [FromRoute] int id
        )
        {
            var data = _roomQueries.GetGuestRoom(id);
            return Ok(data);
        }

        [HttpGet]
        [Route("room/products")]
        public IActionResult GetRoomProductsExpense()
        {
            return Ok();
        }

        [HttpPut]
        [Route("room/status/{id}")]
        public IActionResult ChangeRoomStatus(
            [FromRoute] int id,
            [FromBody] StatusViewModel status
        )
        {
            _roomRepository
                .UpdateStatus(id, status.Status);

            _roomRepository
                .Save();

            return Ok();
        }
    }
}