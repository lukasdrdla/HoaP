using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels.Customer;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface ICustomerRepository
    {
        Task<List<CustomerViewModel>> GetCustomersAsync();
        Task<UpdateCustomerViewModel> GetCustomerByIdAsync(int id);
        Task CreateCustomerAsync(CreateCustomerViewModel customer);
        Task UpdateCustomerAsync(UpdateCustomerViewModel customer);
        Task DeleteCustomerAsync(int id);
    }
}
