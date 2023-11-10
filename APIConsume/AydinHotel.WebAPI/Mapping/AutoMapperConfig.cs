using AutoMapper;
using AydinHotel.DTOs.DTOs.RoomDTOs;
using AydinHotel.Entity.Concretes;

namespace AydinHotel.WebAPI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDTO, Room>().ReverseMap();
            CreateMap<RoomUpdateDTO, Room>().ReverseMap();
        }
    }
}
