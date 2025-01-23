using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Invoice;

namespace HoaP.Application.Services
{
    public class InvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public InvoiceService(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public async Task<List<InvoiceViewModel>> GetInvoicesAsync()
        {
            return await _invoiceRepository.GetInvoicesAsync();
        }

        public async Task<DetailInvoiceViewModel> GetInvoiceByIdAsync(int id)
        {
            return await _invoiceRepository.GetInvoiceByIdAsync(id);
        }

        public async Task CreateInvoiceAsync(InvoiceFormViewModel invoice)
        {
            await _invoiceRepository.CreateInvoiceAsync(invoice);
        }

        public async Task UpdateInvoiceAsync(InvoiceFormViewModel invoice)
        {
            await _invoiceRepository.UpdateInvoiceAsync(invoice);
        }

        public async Task DeleteInvoiceAsync(int id)
        {
            await _invoiceRepository.DeleteInvoiceAsync(id);
        }

        public async Task<bool> CheckIfInvoiceExistsForReservation(int reservationId)
        {
            return await _invoiceRepository.CheckIfInvoiceExistsForReservation(reservationId);
        }

        public async Task<List<InvoiceViewModel>> GetInvoiceByReservationIdAsync(int reservationId)
        {
            return await _invoiceRepository.GetInvoiceByReservationIdAsync(reservationId);
        }

        public async Task<List<InvoiceViewModel>> GetInvoicesByCustomerIdAsync(int customerId)
        {
            return await _invoiceRepository.GetInvoicesByCustomerIdAsync(customerId);
        }





    }
}
