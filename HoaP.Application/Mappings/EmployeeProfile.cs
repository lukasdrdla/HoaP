using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.ViewModels.Employee;
using HoaP.Domain.Entities;

namespace HoaP.Application.Mappings
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<AppUser, EmployeeViewModel>()
                .ForMember(dest => dest.CurrencySymbol, opt => opt.MapFrom(src => src.Currency.Symbol));

            CreateMap<AppUser, DetailEmployeeViewModel>()
                .ForMember(dest => dest.InsuranceCompanyName, opt => opt.MapFrom(src => src.InsuranceCompany.Name))
                .ForMember(dest => dest.CurrencySymbol, opt => opt.MapFrom(src => src.Currency.Symbol))
                .ForMember(dest => dest.CurrencyId, opt => opt.MapFrom(src => src.CurrencyId))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber));

            CreateMap<DetailEmployeeViewModel, EmployeeFormViewModel>()
                .ForMember(dest => dest.InsuranceCompanyId, opt => opt.MapFrom(src => src.InsuranceCompanyId))
                .ForMember(dest => dest.CurrencyId, opt => opt.MapFrom(src => src.CurrencyId))
                .ForMember(dest => dest.RoleId, opt => opt.MapFrom(src => src.RoleId));

            CreateMap<EmployeeFormViewModel, AppUser>()
                .ForMember(dest => dest.CurrencyId, opt => opt.MapFrom(src => src.CurrencyId));

            CreateMap<AppUser, UpdateEmployeeViewModel>();


        }
    }
}
