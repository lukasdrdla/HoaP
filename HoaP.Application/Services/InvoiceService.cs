using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Invoice;
using HoaP.Domain.Entities;

namespace HoaP.Application.Services
{
    public class InvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IMapper _mapper;

        public InvoiceService(IInvoiceRepository invoiceRepository, IMapper mapper)
        {
            _invoiceRepository = invoiceRepository;
            _mapper = mapper;
        }

        public async Task<List<InvoiceViewModel>> GetInvoicesAsync()
        {
            var entities = await _invoiceRepository.GetInvoicesAsync();
            return _mapper.Map<List<InvoiceViewModel>>(entities);
        }

        public async Task<DetailInvoiceViewModel> GetInvoiceByIdAsync(int id)
        {
            var entity = await _invoiceRepository.GetInvoiceByIdAsync(id);
            return _mapper.Map<DetailInvoiceViewModel>(entity);
        }

        public async Task CreateInvoiceAsync(InvoiceFormViewModel invoice)
        {
            var entity = _mapper.Map<Invoice>(invoice);
            entity.AppUserId = invoice.UserId ?? string.Empty;
            await _invoiceRepository.CreateInvoiceAsync(entity, invoice.ReservationIds);
        }

        public async Task UpdateInvoiceAsync(InvoiceFormViewModel invoice)
        {
            var entity = _mapper.Map<Invoice>(invoice);
            entity.AppUserId = invoice.UserId ?? string.Empty;
            await _invoiceRepository.UpdateInvoiceAsync(entity, invoice.ReservationIds);
        }

        public async Task DeleteInvoiceAsync(int id)
        {
            await _invoiceRepository.DeleteInvoiceAsync(id);
        }

        public async Task CancelInvoiceAsync(int id)
        {
            await _invoiceRepository.CancelInvoiceAsync(id);
        }

        public async Task<bool> CheckIfInvoiceExistsForReservation(int reservationId)
        {
            return await _invoiceRepository.CheckIfInvoiceExistsForReservation(reservationId);
        }

        public async Task<List<InvoiceViewModel>> GetInvoiceByReservationIdAsync(int reservationId)
        {
            var entities = await _invoiceRepository.GetInvoiceByReservationIdAsync(reservationId);
            return _mapper.Map<List<InvoiceViewModel>>(entities);
        }

        public async Task<List<InvoiceViewModel>> GetInvoicesByCustomerIdAsync(int customerId)
        {
            var entities = await _invoiceRepository.GetInvoicesByCustomerIdAsync(customerId);
            return _mapper.Map<List<InvoiceViewModel>>(entities);
        }

        public async Task<Invoice> GetInvoiceEntityByIdAsync(int id)
        {
            return await _invoiceRepository.GetInvoiceEntityByIdAsync(id);
        }
    }
}
