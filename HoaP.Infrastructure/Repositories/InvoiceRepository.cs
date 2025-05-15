using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Invoice;
using HoaP.Domain.Entities;
using HoaP.Domain.Interfaces;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public InvoiceRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<bool> CheckIfInvoiceExistsForReservation(int reservationId)
        {
            throw new NotImplementedException();
        }

        public async Task<Invoice?> GetInvoiceEntityByIdAsync(int id)
        {
            return await _context.Invoices
                .Include(i => i.Reservations)
                    .ThenInclude(r => r.ReservationCustomers)
                        .ThenInclude(rc => rc.Customer)
                .Include(i => i.Reservations)
                    .ThenInclude(r => r.Room)
                        .ThenInclude(room => room.RoomType)
                .Include(i => i.Currency)
                .Include(i => i.AppUser)
                .Include(i => i.Items)
                .FirstOrDefaultAsync(i => i.Id == id);
        }




        public async Task CreateInvoiceAsync(InvoiceFormViewModel invoice)
        {

            if (invoice.ReservationIds == null || !invoice.ReservationIds.Any())
                throw new ArgumentException("Faktura musí obsahovat alespoň jednu rezervaci.");


            var entity = _mapper.Map<Invoice>(invoice);

            var reservations = await _context.Reservations
                .Where(r => invoice.ReservationIds.Contains(r.Id))
                .ToListAsync();

            entity.Reservations = reservations;

            var currencies = await _context.Currencies.ToListAsync();

            decimal basePriceCZK = 0;

            foreach (var reservation in reservations)
            {
                var currency = currencies.FirstOrDefault(c => c.Symbol == reservation.Currency.Symbol);
                if (currency == null || currency.Rate <= 0)
                    throw new Exception($"Kurz měny {reservation.Currency.Symbol} není platný.");

                basePriceCZK += reservation.TotalPrice * currency.Rate;
            }

            if (invoice.Items != null && invoice.Items.Any())
            {
                basePriceCZK += invoice.Items.Sum(i => i.Price);
            }

            if (invoice.Discount > 0)
                basePriceCZK -= basePriceCZK * invoice.Discount / 100;

            if (invoice.Prepayment > 0)
                basePriceCZK -= invoice.Prepayment;

            if (basePriceCZK < 0)
                basePriceCZK = 0;

            var selectedCurrency = currencies.FirstOrDefault(c => c.Id == invoice.CurrencyId);
            if (selectedCurrency == null || selectedCurrency.Rate <= 0)
                throw new Exception("Nelze určit cílovou měnu nebo její kurz.");

            // Přepočet CZK do měny faktury
            entity.Price = Math.Round(basePriceCZK / selectedCurrency.Rate, 2);
            entity.CurrencyId = selectedCurrency.Id;

            await _context.Invoices.AddAsync(entity);
            await _context.SaveChangesAsync();

            foreach (var reservation in reservations)
            {
                reservation.InvoiceId = entity.Id;
            }

            await _context.SaveChangesAsync();
        }

        public async Task CancelInvoiceAsync(int id)
        {
            var existingInvoice = await _context.Invoices.FindAsync(id);
            if (existingInvoice != null)
            {
                if (existingInvoice.IsPaid)
                {
                    throw new Exception("Fakturu nelze stornovat, protože je již zaplacena.");
                }

                if (existingInvoice.IsCanceled)
                {
                    throw new Exception("Faktura je již stornována.");
                }

                existingInvoice.IsCanceled = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<DetailInvoiceViewModel> GetInvoiceByIdAsync(int id)
        {
            var invoice = await _context.Invoices
                .Include(i => i.Reservations)
                        .ThenInclude(r => r.ReservationCustomers)
                            .ThenInclude(rc => rc.Customer)
                .Include(i => i.Reservations)
                        .ThenInclude(r => r.Room)
                            .ThenInclude(room => room.RoomType)
                .Include(i => i.Currency)
                .Include(i => i.AppUser)
                .Include(i => i.Items)
                .FirstOrDefaultAsync(i => i.Id == id);

            return _mapper.Map<DetailInvoiceViewModel>(invoice);
        }


        public async Task<List<InvoiceViewModel>> GetInvoiceByReservationIdAsync(int reservationId)
        {
            var invoices = await _context.Invoices
                .Include(i => i.Reservations)
                    .ThenInclude(r => r.Customer)
                .Where(i => i.Reservations.Any(ir => ir.Id == reservationId))
                .ToListAsync();

            return _mapper.Map<List<InvoiceViewModel>>(invoices);
        }

        public async Task<List<InvoiceViewModel>> GetInvoicesAsync()
        {
            var invoices = await _context.Invoices
                .Include(i => i.Reservations)
                    .ThenInclude(r => r.Customer)
                .Include(i => i.Currency)
                .ToListAsync();

            return _mapper.Map<List<InvoiceViewModel>>(invoices);
        }


        public async Task<List<InvoiceViewModel>> GetInvoicesByCustomerIdAsync(int customerId)
        {
            var invoices = await _context.Invoices
                .Include(i => i.Reservations)
                .ThenInclude(r => r.Customer)
                .Where(i => i.Reservations.Any(r => r.CustomerId == customerId))
                .ToListAsync();

            return _mapper.Map<List<InvoiceViewModel>>(invoices);
        }


        public async Task UpdateInvoiceAsync(InvoiceFormViewModel invoice)
        {
            var existingInvoice = await _context.Invoices
                .Include(i => i.Reservations)
                .Include(i => i.Items)
                .FirstOrDefaultAsync(i => i.Id == invoice.Id);

            if (existingInvoice == null)
                return;


            _mapper.Map(invoice, existingInvoice);

            var updatedReservations = await _context.Reservations
                .Where(r => invoice.ReservationIds.Contains(r.Id))
                .ToListAsync();

            existingInvoice.Reservations.Clear();
            foreach (var r in updatedReservations)
            {
                existingInvoice.Reservations.Add(r);
            }

            _context.InvoiceItems.RemoveRange(existingInvoice.Items);
            existingInvoice.Items = invoice.Items.Select(i => new InvoiceItem
            {
                Description = i.Description,
                Price = i.Price,
                InvoiceId = existingInvoice.Id
            }).ToList();

            var currencies = await _context.Currencies.ToListAsync();

            decimal basePriceCZK = 0;

            foreach (var reservation in updatedReservations)
            {
                var currency = currencies.FirstOrDefault(c => c.Symbol == reservation.Currency.Symbol);
                if (currency == null || currency.Rate <= 0)
                    throw new Exception($"Kurz měny {reservation.Currency.Symbol} není platný.");

                basePriceCZK += reservation.TotalPrice * currency.Rate;
            }

            if (invoice.Items != null && invoice.Items.Any())
            {
                basePriceCZK += invoice.Items.Sum(i => i.Price);
            }

            if (invoice.Discount > 0)
                basePriceCZK -= basePriceCZK * invoice.Discount / 100;

            if (invoice.Prepayment > 0)
                basePriceCZK -= invoice.Prepayment;

            if (basePriceCZK < 0)
                basePriceCZK = 0;

            var selectedCurrency = currencies.FirstOrDefault(c => c.Id == invoice.CurrencyId);
            if (selectedCurrency == null || selectedCurrency.Rate <= 0)
                throw new Exception("Nelze určit cílovou měnu nebo její kurz.");

            // Přepočet zpět do měny faktury
            existingInvoice.Price = Math.Round(basePriceCZK / selectedCurrency.Rate, 2);
            existingInvoice.CurrencyId = selectedCurrency.Id;

            existingInvoice.UpdatedAt = DateTime.Now;

            await _context.SaveChangesAsync();
        }


        public async Task DeleteInvoiceAsync(int id)
        {
            var invoice = await _context.Invoices.FindAsync(id);
            if (invoice != null)
            {
                if (invoice.IsPaid)
                {
                    throw new Exception("Fakturu nelze smazat, protože je již zaplacena.");
                }

                _context.Invoices.Remove(invoice);
                await _context.SaveChangesAsync();
            }
        }
    }
}
