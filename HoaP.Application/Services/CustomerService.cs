using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Customer;
using HoaP.Domain.Entities;

namespace HoaP.Application.Services
{
    public class CustomerService 
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<List<CustomerViewModel>> GetCustomers()
        {
            return await _customerRepository.GetCustomersAsync();
        }

        public async Task<DetailCustomerViewModel> GetCustomerById(int id)
        {
            return await _customerRepository.GetCustomerByIdAsync(id);
        }

        public async Task CreateCustomer(CustomerFormViewModel customer)
        {
            await _customerRepository.CreateCustomerAsync(customer);
        }

        public async Task UpdateCustomer(CustomerFormViewModel customer)
        {
            await _customerRepository.UpdateCustomerAsync(customer);
        }

        public async Task DeleteCustomer(int id)
        {
            await _customerRepository.DeleteCustomerAsync(id);
        }
    }
}
