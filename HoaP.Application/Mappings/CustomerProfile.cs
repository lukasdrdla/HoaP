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

            CreateMap<Customer, CustomerViewModel>();
            
            CreateMap<CustomerFormViewModel, Customer>();

            CreateMap<DetailCustomerViewModel, CustomerFormViewModel>();
            CreateMap<CustomerFormViewModel, DetailCustomerViewModel>();

            CreateMap<Customer, DetailCustomerViewModel>();
        }
    }
}
