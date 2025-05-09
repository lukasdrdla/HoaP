using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.ViewModels.Amenity;
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
                .ForMember(dest => dest.IsDisable, opt => opt.MapFrom(src => src.IsDisable))
                .ForMember(dest => dest.CurrencySymbol, opt => opt.MapFrom(src => src.Currency.Symbol))
                .ForMember(dest => dest.MaxChildren, opt => opt.MapFrom(src => src.MaxChildren));

            CreateMap<Room, DetailRoomViewModel>()
                .ForMember(dest => dest.RoomStatusName, opt => opt.MapFrom(src => src.RoomStatus.Name))
                .ForMember(dest => dest.RoomTypeName, opt => opt.MapFrom(src => src.RoomType.Name))
                .ForMember(dest => dest.CurrencyId, opt => opt.MapFrom(src => src.CurrencyId))
                .ForMember(dest => dest.CurrencySymbol, opt => opt.MapFrom(src => src.Currency.Symbol))
                .ForMember(dest => dest.Amenities, opt => opt.MapFrom(src =>
                    src.RoomAmenities.Select(ra => new AmenityViewModel
                    {
                        Id = ra.AmenityId,
                        Name = ra.Amenity.Name,
                        isSelected = true
                    })));



            CreateMap<RoomFormViewModel, Room>()
                    .ForMember(dest => dest.CurrencyId, opt => opt.MapFrom(src => src.CurrencyId))
                    .ForMember(dest => dest.RoomStatusId, opt => opt.MapFrom(src => src.RoomStatusId))
                    .ForMember(dest => dest.RoomTypeId, opt => opt.MapFrom(src => src.RoomTypeId))
                    .ForMember(dest => dest.MaxAdults, opt => opt.MapFrom(src => src.MaxAdults))
                    .ForMember(dest => dest.MaxChildren, opt => opt.MapFrom(src => src.MaxChildren))
                    .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                    .ForMember(dest => dest.RoomNumber, opt => opt.MapFrom(src => src.RoomNumber))
                    .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                    .ForMember(dest => dest.RoomAmenities, opt => opt.MapFrom(src =>
                        src.Amenities.Select(a => new RoomAmenity { AmenityId = a.Id })))
                    .ForMember(dest => dest.CurrencyId, opt => opt.MapFrom(src => src.CurrencyId))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));


            CreateMap<DetailRoomViewModel, RoomViewModel>().ReverseMap();

            CreateMap<DetailRoomViewModel, RoomFormViewModel>();
            CreateMap<RoomFormViewModel, DetailRoomViewModel>();

            CreateMap<Room, RoomFormViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.RoomNumber, opt => opt.MapFrom(src => src.RoomNumber))
                .ForMember(dest => dest.RoomTypeId, opt => opt.MapFrom(src => src.RoomTypeId))
                .ForMember(dest => dest.RoomStatusId, opt => opt.MapFrom(src => src.RoomStatusId))
                .ForMember(dest => dest.MaxAdults, opt => opt.MapFrom(src => src.MaxAdults))
                .ForMember(dest => dest.MaxChildren, opt => opt.MapFrom(src => src.MaxChildren))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                .ForMember(dest => dest.CurrencyId, opt => opt.MapFrom(src => src.CurrencyId))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Amenities, opt => opt.MapFrom(src =>
                    src.RoomAmenities.Select(ra => new AmenityViewModel
                    {
                        Id = ra.AmenityId,
                        Name = ra.Amenity.Name,
                        isSelected = true
                    })));









        }
    }
}
