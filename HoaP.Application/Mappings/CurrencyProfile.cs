using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.ViewModels.Currency;
using HoaP.Domain.Entities;

namespace HoaP.Application.Mappings
{
    public class CurrencyProfile : Profile
    {
        public CurrencyProfile()
        {
            CreateMap<Currency, CurrencyViewModel>().ReverseMap();
        }
    }
}
