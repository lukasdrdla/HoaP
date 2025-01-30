using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.ViewModels.Room;
using HoaP.Domain.Entities;

namespace HoaP.Application.Mappings
{
    public class RoomProfile : Profile
    {
        public RoomProfile() { 
        
            CreateMap<Room, RoomViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.RoomNumber, opt => opt.MapFrom(src => src.RoomNumber))
                .ForMember(dest => dest.RoomTypeName, opt => opt.MapFrom(src => src.RoomType.Name))
                .ForMember(dest => dest.RoomStatusName, opt => opt.MapFrom(src => src.RoomStatus.Name))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.MaxAdults, opt => opt.MapFrom(src => src.MaxAdults))
                .ForMember(dest => dest.MaxChildren, opt => opt.MapFrom(src => src.MaxChildren));

            CreateMap<Room, DetailRoomViewModel>()
                .ForMember(dest => dest.RoomStatusName, opt => opt.MapFrom(src => src.RoomStatus.Name))
                .ForMember(dest => dest.RoomTypeName, opt => opt.MapFrom(src => src.RoomType.Name));

            CreateMap<RoomFormViewModel, Room>();

            CreateMap<DetailRoomViewModel, RoomViewModel>().ReverseMap();

            CreateMap<DetailRoomViewModel, RoomFormViewModel>();
            CreateMap<RoomFormViewModel, DetailRoomViewModel>();
                





        }
    }
}
