using AutoMapper;
using AydinHotel.Entity.Concretes;
using AydinHotel.WebUI.DTOs.AboutDTOs;
using AydinHotel.WebUI.DTOs.AppUserDTOs;
using AydinHotel.WebUI.DTOs.BookingDTOs;
using AydinHotel.WebUI.DTOs.GuestDTOs;
using AydinHotel.WebUI.DTOs.LoginDTOs;
using AydinHotel.WebUI.DTOs.RegisterDTOs;
using AydinHotel.WebUI.DTOs.ServiceDTOs;
using AydinHotel.WebUI.DTOs.StaffDTOs;
using AydinHotel.WebUI.DTOs.SubscribeDTOs;

namespace AydinHotel.WebUI.Mapping.Automapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CreateServiceDTO, Service>().ReverseMap();
            CreateMap<ResultServiceDTO, Service>().ReverseMap();
            CreateMap<UpdateServiceDTO, Service>().ReverseMap();

            CreateMap<AppUser, CreateNewUserDTO>().ReverseMap();
            CreateMap<AppUser, LoginUserDTO>().ReverseMap();

            CreateMap<UpdateAboutDTO, About>().ReverseMap();
            CreateMap<ResultAboutDTO, About>().ReverseMap();
            CreateMap<ResultStaffDTO, Staff>().ReverseMap();
            CreateMap<CreateSubscribeDTO, Subscribe>().ReverseMap();

            CreateMap<CreateBookingDTO, Booking>().ReverseMap();
            CreateMap<ApprovedReservationDTO, Booking>().ReverseMap();

            CreateMap<CreateGuestDTO, Guest>().ReverseMap();
            CreateMap<UpdateGuestDTO, Guest>().ReverseMap();

            CreateMap<ResultAppUserDTO, AppUser>().ReverseMap();
        }
    }
}
