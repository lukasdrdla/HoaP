using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.ViewModels;
using HoaP.Application.ViewModels.Room;
using HoaP.Application.ViewModels.ServiceR;
using HoaP.Domain.Entities;

namespace HoaP.Application.Mappings
{
    public class ReservationProfile : Profile
    {
        public ReservationProfile()
        {
            CreateMap<DetailReservationViewModel, ReservationViewModel>()
                .ForMember(dest => dest.Guests, opt => opt.Ignore());



            CreateMap<DetailReservationViewModel, ReservationFormViewModel>().ReverseMap();

            CreateMap<ReservationFormViewModel, Reservation>();

            CreateMap<Reservation, ReservationFormViewModel>()
            .ForMember(dest => dest.OriginalMealPlanPrice, opt => opt.MapFrom(src => src.MealPlan != null ? src.MealPlan.Price : 0))
            .ForMember(dest => dest.MealPlanConvertedPrice, opt => opt.MapFrom(src => src.MealPlan != null ? src.MealPlan.Price : 0));


            CreateMap<Reservation, ReservationViewModel>()
                .ForMember(dest => dest.RoomNumber, opt => opt.MapFrom(src => src.Room.RoomNumber))
                .ForMember(dest => dest.ReservationStatusName, opt => opt.MapFrom(src => src.ReservationStatus.Name))
                .ForMember(dest => dest.CurrencySymbol, opt => opt.MapFrom(src => src.Currency.Symbol))
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src =>
                    src.ReservationCustomers.FirstOrDefault(rc => rc.IsMainGuest).Customer.FirstName + " " +
                    src.ReservationCustomers.FirstOrDefault(rc => rc.IsMainGuest).Customer.LastName))
                .ForMember(dest => dest.HasInvoice, opt => opt.MapFrom(src => src.InvoiceReservations.Any()));



            CreateMap<ServiceReservation, ServiceReservationViewModel>()
                .ForMember(dest => dest.ServiceName, opt => opt.MapFrom(src => src.Service.Name));

            CreateMap<Reservation, DetailReservationViewModel>()
                .ForMember(dest => dest.RoomNumber, opt => opt.MapFrom(src => src.Room.RoomNumber))
                .ForMember(dest => dest.RoomTypeName, opt => opt.MapFrom(src => src.Room.RoomType.Name))
                .ForMember(dest => dest.RoomImage, opt => opt.MapFrom(src => src.Room.Image))
                .ForMember(dest => dest.ReservationStatusName, opt => opt.MapFrom(src => src.ReservationStatus.Name))
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer.FirstName + " " + src.Customer.LastName))
                .ForMember(dest => dest.CustomerEmail, opt => opt.MapFrom(src => src.Customer.Email))
                .ForMember(dest => dest.MealPlanName, opt => opt.MapFrom(src => src.MealPlan.Name))
                .ForMember(dest => dest.RoomTypeId, opt => opt.MapFrom(src => src.Room.RoomTypeId))
                .ForMember(dest => dest.HasInvoice, opt => opt.MapFrom(src => src.InvoiceReservations.Any()))
                .ForMember(dest => dest.Services, opt => opt.MapFrom(src => src.ServiceReservations))
                .ForMember(dest => dest.CurrencySymbol, opt => opt.MapFrom(src => src.Currency.Symbol))
                .ForMember(dest => dest.HasInvoice, opt => opt.MapFrom(src => src.InvoiceReservations.Any()))
                .ForMember(dest => dest.Services,
                    opt => opt.MapFrom(src =>
                        src.ServiceReservations.Select(sr => new ServiceReservationViewModel
                        {
                            ServiceName = sr.Service.Name,
                            Quantity = sr.Quantity,
                            UnitPrice = sr.UnitPrice,
                            Note = sr.Note
                        }).ToList()
                    )
                )
                .ForMember(dest => dest.IsInvoicePaid, opt => opt.MapFrom(src => src.InvoiceReservations.Any() && src.InvoiceReservations.FirstOrDefault().Invoice.IsPaid))
                .ForMember(dest => dest.Customer, opt => opt.MapFrom(src => src.Customer));


            CreateMap<ServiceReservation, ServiceReservationViewModel>().ReverseMap();




        }
    }
}
