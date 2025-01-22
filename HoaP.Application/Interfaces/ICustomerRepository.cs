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
        Task<DetailCustomerViewModel> GetCustomerByIdAsync(int id);
        Task CreateCustomerAsync(CustomerFormViewModel customer);
        Task UpdateCustomerAsync(CustomerFormViewModel customer);
        Task DeleteCustomerAsync(int id);
    }
}
