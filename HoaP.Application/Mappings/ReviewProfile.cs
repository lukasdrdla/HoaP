using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.ViewModels.Review;
using HoaP.Domain.Entities;

namespace HoaP.Application.Mappings
{
    public class ReviewProfile : Profile
    {
        public ReviewProfile()
        {
            
            CreateMap<Review, ReviewViewModel>()
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer.FirstName + " " + src.Customer.LastName))
                .ForMember(dest => dest.RoomId, opt => opt.MapFrom(src => src.Room.Id))
                .ReverseMap();

        }
    }
}
