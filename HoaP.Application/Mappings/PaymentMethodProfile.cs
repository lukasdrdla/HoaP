using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.ViewModels.Payment;
using HoaP.Domain.Entities;

namespace HoaP.Application.Mappings
{
    public class PaymentMethodProfile : Profile
    {
        public PaymentMethodProfile()
        {
            CreateMap<PaymentMethod, PaymentMethodViewModel>().ReverseMap();

        }
    }
}
