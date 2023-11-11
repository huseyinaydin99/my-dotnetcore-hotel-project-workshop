using AutoMapper;
using AydinHotel.Entity.Concretes;
using AydinHotel.WebUI.DTOs.ServiceDTO;

namespace AydinHotel.WebUI.Mapping.Automapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CreateServiceDTO, Service>().ReverseMap();
            CreateMap<ResultServiceDTO, Service>().ReverseMap();
            CreateMap<UpdateServiceDTO, Service>().ReverseMap();
        }
    }
}
