﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.ViewModels.Payment;
using HoaP.Domain.Entities;

namespace HoaP.Application.Mappings
{
    public class PaymentProfile : Profile
    {

        public PaymentProfile()
        {
            CreateMap<Payment, PaymentViewModel>()
                .ForMember(dest => dest.InvoiceNumber, opt => opt.MapFrom(src => src.InvoiceId))
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Invoice.Reservation.Customer.FirstName + " " + src.Invoice.Reservation.Customer.LastName));

            CreateMap<Payment, DetailPaymentViewModel>()
                .ForMember(dest => dest.InvoiceNumber, opt => opt.MapFrom(src => src.InvoiceId))
                .ForMember(dest => dest.PaymentMethodName, opt => opt.MapFrom(src => src.PaymentMethod.Name))
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Invoice.Reservation.Customer.FirstName + " " + src.Invoice.Reservation.Customer.LastName));

            CreateMap<DetailPaymentViewModel, PaymentFormViewModel>();

            CreateMap<PaymentFormViewModel, Payment>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.InvoiceId, opt => opt.MapFrom(src => src.InvoiceId))
                .ForMember(dest => dest.TotalAmount, opt => opt.MapFrom(src => src.TotalAmount))
                .ForMember(dest => dest.PaymentDate, opt => opt.MapFrom(src => src.PaymentDate))
                .ForMember(dest => dest.PaymentMethodId, opt => opt.MapFrom(src => src.PaymentMethodId));
        }
    }
}
