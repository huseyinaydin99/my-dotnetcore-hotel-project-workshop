using AutoMapper;
using AydinHotel.Business.Abstracts;
using AydinHotel.DTOs.DTOs.RoomDTOs;
using AydinHotel.Entity.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace AydinHotel.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;
        public Room2Controller(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_roomService.TGetList());
        }

        [HttpPost]
        public IActionResult AddRoom(RoomAddDTO roomAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var values = _mapper.Map<Room>(roomAddDto);
            _roomService.TInsert(values);
            return Ok("Oda kaydı yapıldı.");
        }

        [HttpPut]
        public IActionResult UpdateRoom(RoomUpdateDTO roomUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var values = _mapper.Map<Room>(roomUpdateDto);
            _roomService.TUpdate(values);
            return Ok("Oda başarı ile güncellendi.");
        }
    }
}
