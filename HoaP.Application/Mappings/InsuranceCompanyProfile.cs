using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.ViewModels.InsuranceCompany;
using HoaP.Domain.Entities;

namespace HoaP.Application.Mappings
{
    public class InsuranceCompanyProfile : Profile
    {
        public InsuranceCompanyProfile()
        {
            
            CreateMap<InsuranceCompany, InsuranceCompanyViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Website, opt => opt.MapFrom(src => src.Website));

        }
    }
}
