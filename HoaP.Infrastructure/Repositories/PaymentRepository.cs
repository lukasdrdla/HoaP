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
    public class PaymentRepository : IPaymentRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public PaymentRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreatePaymentAsync(PaymentFormViewModel payment)
        {
            await _context.Payments.AddAsync(_mapper.Map<Payment>(payment));

            var invoice = await _context.Invoices.FindAsync(payment.InvoiceId);
            if (invoice != null)
            {
                invoice.IsPaid = true;
                _context.Invoices.Update(invoice);
            }


            await _context.SaveChangesAsync();
        }

        public async Task DeletePaymentAsync(Guid id)
        {
            var payment = await _context.Payments.FindAsync(id);
            if (payment != null)
            {
                _context.Payments.Remove(payment);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<DetailPaymentViewModel> GetPaymentByIdAsync(Guid id)
        {
            var payment = await _context.Payments
                .Include(p => p.Invoice)
                .ThenInclude(i => i.Reservation)
                .ThenInclude(r => r.Customer)
                .Include(p => p.PaymentMethod)
                .FirstOrDefaultAsync(p => p.Id == id);

            return _mapper.Map<DetailPaymentViewModel>(payment);



        }

        public Task<List<PaymentViewModel>> GetPaymentsAsync()
        {
            var payments = _context.Payments
                .Include(p => p.Invoice)
                .ThenInclude(i => i.Reservation)
                .ThenInclude(r => r.Customer)
                .Include(p => p.PaymentMethod)
                .ToList();

            return Task.FromResult(_mapper.Map<List<PaymentViewModel>>(payments));
        }

        public async Task<List<PaymentViewModel>> GetPaymentsByReservationIdAsync(int reservationId)
        {
            var payments = await _context.Payments
                .Include(p => p.Invoice)
                .ThenInclude(i => i.Reservation)
                .ThenInclude(r => r.Customer)
                .Where(p => p.Invoice.ReservationId == reservationId)
                .ToListAsync();

            return _mapper.Map<List<PaymentViewModel>>(payments);

        }

        public async Task UpdatePaymentAsync(PaymentFormViewModel payment)
        {


            var existingPayment = await _context.Payments.FindAsync(payment.Id);

            if (existingPayment != null)
            {
                _mapper.Map(payment, existingPayment);
                _context.Payments.Update(existingPayment);
                await _context.SaveChangesAsync();
            }

        }
    }
}
