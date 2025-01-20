using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.ViewModels.Amenity;
using HoaP.Domain.Entities;

namespace HoaP.Application.Mappings
{
    public class AmenityProfile : Profile
    {
        public AmenityProfile()
        {
            CreateMap<RoomAmenity, AmenityViewModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Amenity.Name))
                .ForMember(dest => dest.Icon, opt => opt.MapFrom(src => src.Amenity.Icon));



        }
    }
}
