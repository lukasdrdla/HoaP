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
    public class PaymentRepository : IPaymentRepository
    {
        private readonly ApplicationDbContext _context;

        public PaymentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreatePaymentAsync(Payment payment)
        {
            if (payment.PaymentMethodId == 0)
            {
                throw new ArgumentException("Musíte vybrat způsob platby.");
            }
            else if (payment.InvoiceId == 0)
            {
                throw new ArgumentException("Musíte vybrat fakturu.");
            }

            var invoice = await _context.Invoices.FindAsync(payment.InvoiceId);
            if (invoice != null)
            {
                invoice.IsPaid = true;
                payment.CurrencyId = invoice.CurrencyId;
            }

            await _context.Payments.AddAsync(payment);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePaymentAsync(Guid id)
        {
            var payment = await _context.Payments.FindAsync(id);
            if (payment != null)
            {
                var invoice = await _context.Invoices.FindAsync(payment.InvoiceId);
                if (invoice != null)
                {
                    invoice.IsPaid = false;
                    _context.Invoices.Update(invoice);
                }
                _context.Payments.Remove(payment);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Payment?> GetPaymentByIdAsync(Guid id)
        {
            return await _context.Payments
                .AsNoTracking()
                .Include(p => p.Invoice)
                    .ThenInclude(i => i.Reservations)
                        .ThenInclude(r => r.Customer)
                .Include(p => p.Invoice)
                .Include(p => p.Currency)
                .Include(p => p.PaymentMethod)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Payment>> GetPaymentsAsync()
        {
            return await _context.Payments
                .AsNoTracking()
                .Include(p => p.Invoice)
                    .ThenInclude(i => i.Currency)
                .Include(p => p.Invoice)
                    .ThenInclude(i => i.Reservations)
                        .ThenInclude(r => r.ReservationCustomers)
                            .ThenInclude(rc => rc.Customer)
                .Include(p => p.PaymentMethod)
                .ToListAsync();
        }

        public async Task<List<Payment>> GetPaymentsByReservationIdAsync(int reservationId)
        {
            return await _context.Payments
                .AsNoTracking()
                .Include(p => p.Invoice)
                    .ThenInclude(i => i.Currency)
                .Include(p => p.Invoice)
                    .ThenInclude(i => i.Reservations)
                        .ThenInclude(r => r.ReservationCustomers)
                            .ThenInclude(rc => rc.Customer)
                .Include(p => p.PaymentMethod)
                .Where(p => p.Invoice.Reservations.Any(r => r.Id == reservationId))
                .ToListAsync();
        }

        public async Task UpdatePaymentAsync(Payment payment)
        {
            var existingPayment = await _context.Payments.FindAsync(payment.Id);

            if (existingPayment != null)
            {
                _context.Entry(existingPayment).CurrentValues.SetValues(payment);
                existingPayment.UpdatedAt = DateTime.Now;
                await _context.SaveChangesAsync();
            }
        }
    }
}
