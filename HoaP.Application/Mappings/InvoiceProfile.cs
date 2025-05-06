using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.ViewModels.Invoice;
using HoaP.Domain.Entities;

namespace HoaP.Application.Mappings
{
    public class InvoiceProfile : Profile
    {
        public InvoiceProfile()
        {
            CreateMap<Invoice, InvoiceViewModel>()
                .ForMember(dest => dest.CurrencyName, opt => opt.MapFrom(src => src.Currency.Name))
                .ForMember(dest => dest.CurrencySymbol, opt => opt.MapFrom(src => src.Currency.Symbol))
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.InvoiceReservations.FirstOrDefault().Reservation.Customer.FirstName + " " + src.InvoiceReservations.FirstOrDefault().Reservation.Customer.LastName));





            CreateMap<Invoice, DetailInvoiceViewModel>()
                .ForMember(dest => dest.CurrencyName, opt => opt.MapFrom(src => src.Currency.Name))
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.AppUser.FirstName + " " + src.AppUser.LastName))
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.InvoiceReservations.FirstOrDefault().Reservation.Customer.FirstName + " " + src.InvoiceReservations.FirstOrDefault().Reservation.Customer.LastName));


            CreateMap<InvoiceFormViewModel, DetailInvoiceViewModel>()
                .ForMember(dest => dest.CurrencyName, opt => opt.MapFrom(src => src.Currencies.Find(c => c.Id == src.CurrencyId).Name));
            CreateMap<DetailInvoiceViewModel, InvoiceFormViewModel>()
                .ForMember(dest => dest.CurrencyId, opt => opt.MapFrom(src => src.CurrencyId));

            CreateMap<InvoiceFormViewModel, Invoice>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.IssueDate, opt => opt.MapFrom(src => src.IssueDate))
                .ForMember(dest => dest.DueDate, opt => opt.MapFrom(src => src.DueDate))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Discount, opt => opt.MapFrom(src => src.Discount))
                .ForMember(dest => dest.Prepayment, opt => opt.MapFrom(src => src.Prepayment))
                .ForMember(dest => dest.CurrencyId, opt => opt.MapFrom(src => src.CurrencyId))
                .ForMember(dest => dest.AppUserId, opt => opt.MapFrom(src => src.UserId));






        }
    }
}
