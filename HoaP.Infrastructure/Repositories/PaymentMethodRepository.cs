using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class PaymentMethodRepository : IPaymentMethodRepository
    {
        private readonly ApplicationDbContext _context;

        public PaymentMethodRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreatePaymentMethodAsync(PaymentMethod entity)
        {
            await _context.PaymentMethods.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePaymentMethodAsync(int id)
        {
            var existing = await _context.PaymentMethods.FindAsync(id);
            if (existing != null)
            {
                _context.PaymentMethods.Remove(existing);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<PaymentMethod>> GetAllPaymentMethodsAsync()
        {
            return await _context.PaymentMethods.AsNoTracking().ToListAsync();
        }

        public async Task<PaymentMethod?> GetPaymentMethodByIdAsync(int id)
        {
            return await _context.PaymentMethods.FindAsync(id);
        }

        public async Task UpdatePaymentMethodAsync(PaymentMethod entity)
        {
            _context.PaymentMethods.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
