using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.ViewModels;
using HoaP.Application.ViewModels.Room;
using HoaP.Domain.Entities;

namespace HoaP.Application.Mappings
{
    public class ReservationProfile : Profile
    {
        public ReservationProfile()
        {
            CreateMap<DetailReservationViewModel, ReservationFormViewModel>().ReverseMap();

            CreateMap<ReservationFormViewModel, Reservation>().ReverseMap();

            CreateMap<Reservation, ReservationViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.RoomNumber, opt => opt.MapFrom(src => src.Room.RoomNumber))
                .ForMember(dest => dest.CheckIn, opt => opt.MapFrom(src => src.CheckIn))
                .ForMember(dest => dest.CheckOut, opt => opt.MapFrom(src => src.CheckOut))
                .ForMember(dest => dest.TotalPrice, opt => opt.MapFrom(src => src.TotalPrice))
                .ForMember(dest => dest.ReservationStatusName, opt => opt.MapFrom(src => src.ReservationStatus.Name))
                .ForMember(dest => dest.CurrencySymbol, opt => opt.MapFrom(src => src.Currency.Symbol))
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer.FirstName + " " + src.Customer.LastName));

            CreateMap<Reservation, DetailReservationViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.RoomId, opt => opt.MapFrom(src => src.RoomId))
                .ForMember(dest => dest.RoomNumber, opt => opt.MapFrom(src => src.Room.RoomNumber))
                .ForMember(dest => dest.RoomTypeName, opt => opt.MapFrom(src => src.Room.RoomType.Name))
                .ForMember(dest => dest.RoomImage, opt => opt.MapFrom(src => src.Room.Image))
                .ForMember(dest => dest.CheckIn, opt => opt.MapFrom(src => src.CheckIn))
                .ForMember(dest => dest.CheckOut, opt => opt.MapFrom(src => src.CheckOut))
                .ForMember(dest => dest.TotalPrice, opt => opt.MapFrom(src => src.TotalPrice))
                .ForMember(dest => dest.ReservationStatusName, opt => opt.MapFrom(src => src.ReservationStatus.Name))
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer.FirstName + " " + src.Customer.LastName))
                .ForMember(dest => dest.CustomerEmail, opt => opt.MapFrom(src => src.Customer.Email))
                .ForMember(dest => dest.Adults, opt => opt.MapFrom(src => src.Adults))
                .ForMember(dest => dest.Children, opt => opt.MapFrom(src => src.Children))
                .ForMember(dest => dest.MealPlanName, opt => opt.MapFrom(src => src.MealPlan.Name))
                .ForMember(dest => dest.SpecialRequest, opt => opt.MapFrom(src => src.SpecialRequest))
                .ForMember(dest => dest.AdminNote, opt => opt.MapFrom(src => src.AdminNote))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.MealPlanId, opt => opt.MapFrom(src => src.MealPlanId))
                .ForMember(dest => dest.RoomTypeId, opt => opt.MapFrom(src => src.Room.RoomTypeId))
                .ForMember(dest => dest.HasInvoice, opt => opt.MapFrom(src => src.InvoiceReservations.Any()))
                .ForMember(dest => dest.IsInvoicePaid, opt => opt.MapFrom(src => src.InvoiceReservations.Any() && src.InvoiceReservations.FirstOrDefault().Invoice.IsPaid))
                .ForMember(dest => dest.Customer, opt => opt.MapFrom(src => src.Customer));






        }
    }
}
