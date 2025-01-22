using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels.Invoice;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IInvoiceRepository
    {
        Task<List<InvoiceViewModel>> GetInvoicesAsync();
        Task<DetailInvoiceViewModel> GetInvoiceByIdAsync(int id);
        Task CreateInvoiceAsync(CreateInvoiceViewModel invoice);
        Task UpdateInvoiceAsync(UpdateInvoiceViewModel invoice);
        Task DeleteInvoiceAsync(int id);

        Task<bool> CheckIfInvoiceExistsForReservation(int reservationId);
        Task<List<InvoiceViewModel>> GetInvoiceByReservationIdAsync(int reservationId);
        Task<List<InvoiceViewModel>> GetInvoicesByCustomerIdAsync(int customerId);
    }
}
