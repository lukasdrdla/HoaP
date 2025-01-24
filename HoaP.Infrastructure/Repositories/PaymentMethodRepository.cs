using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Payment;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class PaymentMethodRepository : IPaymentMethodRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public PaymentMethodRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreatePaymentMethodAsync(PaymentMethodViewModel model)
        {
            await _context.PaymentMethods.AddAsync(_mapper.Map<PaymentMethod>(model));
            await _context.SaveChangesAsync();
        }

        public async Task DeletePaymentMethodAsync(int id)
        {
            var existingPaymentMethod = await _context.PaymentMethods.FindAsync(id);
            if (existingPaymentMethod != null)
            {
                _context.PaymentMethods.Remove(existingPaymentMethod);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<PaymentMethodViewModel>> GetAllPaymentMethodsAsync()
        {
            var paymentMethods = await _context.PaymentMethods.ToListAsync();
            return _mapper.Map<List<PaymentMethodViewModel>>(paymentMethods);
        }

        public async Task<PaymentMethodViewModel> GetPaymentMethodByIdAsync(int id)
        {
            var paymentMethod = await _context.PaymentMethods.FindAsync(id);
            return _mapper.Map<PaymentMethodViewModel>(paymentMethod);
        }

        public async Task UpdatePaymentMethodAsync(PaymentMethodViewModel model)
        {
            var existingPaymentMethod = await _context.PaymentMethods.FindAsync(model.Id);
            if (existingPaymentMethod != null)
            {
                _mapper.Map(model, existingPaymentMethod);
                _context.PaymentMethods.Update(existingPaymentMethod);
                await _context.SaveChangesAsync();
            }
        }
    }
}
