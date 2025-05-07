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

        public async Task<Invoice> GetInvoiceEntityByIdAsync(int id)
        {
            return await _context.Invoices
                .Include(i => i.InvoiceReservations)
                    .ThenInclude(ir => ir.Reservation)
                        .ThenInclude(r => r.ReservationCustomers)
                            .ThenInclude(rc => rc.Customer)
                .Include(i => i.InvoiceReservations)
                    .ThenInclude(ir => ir.Reservation)
                        .ThenInclude(r => r.Room)
                            .ThenInclude(room => room.RoomType)
                .Include(i => i.Currency)
                .Include(i => i.AppUser)
                .Include(i => i.Items)
                .FirstOrDefaultAsync(i => i.Id == id);
        }



        public async Task CreateInvoiceAsync(InvoiceFormViewModel invoice)
        {
            // Namapuj view model na entitu
            var entity = _mapper.Map<Invoice>(invoice);

            // Před uložením spočítej celkovou cenu (v CZK)
            decimal total = invoice.Reservations.Sum(r => r.TotalPrice);

            // Připočti ruční položky
            if (invoice.Items != null && invoice.Items.Any())
            {
                total += invoice.Items.Sum(i => i.Price);
            }

            // Sleva
            if (invoice.Discount > 0)
                total -= total * invoice.Discount / 100;

            // Záloha
            if (invoice.Prepayment > 0)
                total -= invoice.Prepayment;

            // Zajištění, že cena není záporná
            if (total < 0)
                total = 0;

            // Ulož výslednou cenu
            entity.Price = total;

            // Přidej fakturu do databáze
            await _context.Invoices.AddAsync(entity);
            await _context.SaveChangesAsync(); // entity.Id je nyní k dispozici

            // Vložení M:N vazeb na rezervace
            foreach (var reservationId in invoice.ReservationIds)
            {
                _context.InvoiceReservations.Add(new InvoiceReservation
                {
                    InvoiceId = entity.Id,
                    ReservationId = reservationId
                });
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
                .Include(i => i.InvoiceReservations)
                    .ThenInclude(ir => ir.Reservation)
                        .ThenInclude(r => r.ReservationCustomers)
                            .ThenInclude(rc => rc.Customer)
                .Include(i => i.InvoiceReservations)
                    .ThenInclude(ir => ir.Reservation)
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
                .Include(i => i.InvoiceReservations)
                .ThenInclude(ir => ir.Reservation)

                .ThenInclude(r => r.Customer)
                .Where(i => i.InvoiceReservations.Any(ir => ir.ReservationId == reservationId))
                .ToListAsync();

            return _mapper.Map<List<InvoiceViewModel>>(invoices);
        }

        public async Task<List<InvoiceViewModel>> GetInvoicesAsync()
        {
            var invoices = await _context.Invoices
            .Include(i => i.InvoiceReservations)
                .ThenInclude(ir => ir.Reservation)
                    .ThenInclude(r => r.ReservationCustomers)
                        .ThenInclude(rc => rc.Customer)
            .Include(i => i.Currency)
            .ToListAsync();

            return _mapper.Map<List<InvoiceViewModel>>(invoices);
        }

        public async Task<List<InvoiceViewModel>> GetInvoicesByCustomerIdAsync(int customerId)
        {
            var invoices = await _context.Invoices
                .Include(i => i.InvoiceReservations)
                .ThenInclude(ir => ir.Reservation)
                .ThenInclude(r => r.Customer)
                .Where(i => i.InvoiceReservations.Any(ir => ir.Reservation.CustomerId == customerId))
                .ToListAsync();

            return _mapper.Map<List<InvoiceViewModel>>(invoices);
        }

        public async Task UpdateInvoiceAsync(InvoiceFormViewModel invoice)
        {
            var existingInvoice = await _context.Invoices.FindAsync(invoice.Id);

            if (existingInvoice == null)
            {
                return;
            }

            _mapper.Map(invoice, existingInvoice);
            _context.Invoices.Update(existingInvoice);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteInvoiceAsync(int id)
        {
            var invoice = await _context.Invoices.FindAsync(id);
            if (invoice != null)
            {
                _context.Invoices.Remove(invoice);
                await _context.SaveChangesAsync();
            }
        }
    }
}
