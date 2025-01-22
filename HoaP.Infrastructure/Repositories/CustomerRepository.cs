using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Customer;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CustomerRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task CreateCustomerAsync(CreateCustomerViewModel customer)
        {
            var customerEntity = _mapper.Map<Customer>(customer);
            await _context.Customers.AddAsync(customerEntity);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteCustomerAsync(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<DetailCustomerViewModel> GetCustomerByIdAsync(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer != null)
            {
                return _mapper.Map<DetailCustomerViewModel>(customer);
            }

            return null;
        }

        public async Task<List<CustomerViewModel>> GetCustomersAsync()
        {
            var customers = await _context.Customers.ToListAsync();
            return _mapper.Map<List<CustomerViewModel>>(customers);

        }

        public async Task UpdateCustomerAsync(UpdateCustomerViewModel customer)
        {
            var existingCustomer = await _context.Customers.FindAsync(customer.Id);

            if (existingCustomer == null)
            {
                return;
            }

            _mapper.Map(customer, existingCustomer);
            _context.Customers.Update(existingCustomer);
            await _context.SaveChangesAsync();
        }
    }
}
