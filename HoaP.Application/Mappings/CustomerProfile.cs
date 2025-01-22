using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.ViewModels.Customer;
using HoaP.Domain.Entities;

namespace HoaP.Application.Mappings
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile() {

            CreateMap<Customer, CustomerViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.PersonalIdentificationNumber, opt => opt.MapFrom(src => src.PersonalIdentificationNumber))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Phone))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));

            CreateMap<CustomerFormViewModel, Customer>();

            CreateMap<DetailCustomerViewModel, CustomerFormViewModel>();
            CreateMap<CustomerFormViewModel, DetailCustomerViewModel>();







            CreateMap<Customer, DetailCustomerViewModel>();





        }

    }
}
