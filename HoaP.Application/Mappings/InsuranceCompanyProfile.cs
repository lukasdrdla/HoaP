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
            
            CreateMap<InsuranceCompany, InsuranceCompanyViewModel>().ReverseMap();

        }
    }
}
