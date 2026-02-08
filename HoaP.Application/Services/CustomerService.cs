using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Customer;
using HoaP.Domain.Entities;

namespace HoaP.Application.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<List<CustomerViewModel>> GetCustomersAsync()
        {
            var entities = await _customerRepository.GetCustomersAsync();
            return _mapper.Map<List<CustomerViewModel>>(entities);
        }

        public async Task<DetailCustomerViewModel> GetCustomerById(int id)
        {
            var entity = await _customerRepository.GetCustomerByIdAsync(id);
            return _mapper.Map<DetailCustomerViewModel>(entity);
        }

        public async Task<CustomerViewModel?> GetCustomerByEmailAsync(string email)
        {
            var entity = await _customerRepository.GetCustomerByEmailAsync(email);
            return entity != null ? _mapper.Map<CustomerViewModel>(entity) : null;
        }

        public async Task<int> CreateCustomerAndReturnIdAsync(CustomerFormViewModel customer)
        {
            var entity = _mapper.Map<Customer>(customer);
            await _customerRepository.CreateCustomerAsync(entity);
            return entity.Id;
        }

        public async Task CreateCustomer(CustomerFormViewModel customer)
        {
            var entity = _mapper.Map<Customer>(customer);
            await _customerRepository.CreateCustomerAsync(entity);
        }

        public async Task UpdateCustomer(CustomerFormViewModel customer)
        {
            var entity = _mapper.Map<Customer>(customer);
            await _customerRepository.UpdateCustomerAsync(entity);
        }

        public async Task DeleteCustomer(int id)
        {
            await _customerRepository.DeleteCustomerAsync(id);
        }
    }
}
