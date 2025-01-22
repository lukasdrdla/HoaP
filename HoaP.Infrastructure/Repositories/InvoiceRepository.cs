using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Invoice;
using HoaP.Domain.Entities;
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

        public async Task CreateInvoiceAsync(CreateInvoiceViewModel invoice)
        {
            await _context.Invoices.AddAsync(_mapper.Map<Invoice>(invoice));
            await _context.SaveChangesAsync();
        }

        public async Task DeleteInvoiceAsync(int id)
        {
            var existingInvoice = await _context.Invoices.FindAsync(id);
            if (existingInvoice != null)
            {
                _context.Invoices.Remove(existingInvoice);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<DetailInvoiceViewModel> GetInvoiceByIdAsync(int id)
        {
            var invoice = await _context.Invoices
                .Include(i => i.Reservation)
                .ThenInclude(r => r.Customer)
                .FirstOrDefaultAsync(i => i.Id == id);

            return _mapper.Map<DetailInvoiceViewModel>(invoice);
        }

        public async Task<List<InvoiceViewModel>> GetInvoiceByReservationIdAsync(int reservationId)
        {
            var invoices = await _context.Invoices
                .Where(i => i.ReservationId == reservationId)
                .ToListAsync();

            return _mapper.Map<List<InvoiceViewModel>>(invoices);
        }

        public async Task<List<InvoiceViewModel>> GetInvoicesAsync()
        {
            var invoices = await _context.Invoices
                .Include(i => i.Reservation)
                .ThenInclude(r => r.Customer)
                .ToListAsync();

            return _mapper.Map<List<InvoiceViewModel>>(invoices);
        }

        public async Task<List<InvoiceViewModel>> GetInvoicesByCustomerIdAsync(int customerId)
        {
            var invoices = await _context.Invoices
                .Include(i => i.Reservation)
                .ThenInclude(r => r.Customer)
                .Where(i => i.Reservation.CustomerId == customerId)
                .ToListAsync();

            return _mapper.Map<List<InvoiceViewModel>>(invoices);
        }

        public Task UpdateInvoiceAsync(UpdateInvoiceViewModel invoice)
        {
            throw new NotImplementedException();
        }
    }
}
