using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.ViewModels.HotelProfile;

namespace HoaP.Application.Mappings
{
    public class HotelProfileProfile : Profile
    {
        public HotelProfileProfile()
        {
            CreateMap<Domain.Entities.HotelProfile, HotelProfileViewModel>().ReverseMap();
        }
    }
}
