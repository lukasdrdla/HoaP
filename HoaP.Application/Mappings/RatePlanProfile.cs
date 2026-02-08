using AutoMapper;
using HoaP.Application.ViewModels.RatePlan;
using HoaP.Domain.Entities;

namespace HoaP.Application.Mappings
{
    public class RatePlanProfile : Profile
    {
        public RatePlanProfile()
        {
            CreateMap<RatePlan, RatePlanViewModel>()
                .ForMember(dest => dest.RoomTypeName, opt => opt.MapFrom(src => src.RoomType != null ? src.RoomType.Name : null))
                .ForMember(dest => dest.RoomNumber, opt => opt.MapFrom(src => src.Room != null ? src.Room.RoomNumber : null));

            CreateMap<RatePlanFormViewModel, RatePlan>();
            CreateMap<RatePlan, RatePlanFormViewModel>();
        }
    }
}
