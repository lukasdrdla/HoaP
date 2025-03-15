using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.ViewModels.Employee;
using HoaP.Domain.Entities;

namespace HoaP.Application.Mappings
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            CreateMap<EmployeeFormViewModel, AppUser>();



            CreateMap<UpdateEmployeeViewModel, AppUser>()
                .ForMember(dest => dest.UserName, opt => opt.Ignore());



        }
    }
}
