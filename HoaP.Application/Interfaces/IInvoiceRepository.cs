using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IInvoiceRepository
    {
        Task<List<Invoice>> GetInvoicesAsync();
        Task<Invoice?> GetInvoiceByIdAsync(int id);
        Task CreateInvoiceAsync(Invoice invoice, List<int> reservationIds);
        Task UpdateInvoiceAsync(Invoice invoice, List<int> reservationIds);
        Task DeleteInvoiceAsync(int id);
        Task CancelInvoiceAsync(int id);

        Task<bool> CheckIfInvoiceExistsForReservation(int reservationId);
        Task<List<Invoice>> GetInvoiceByReservationIdAsync(int reservationId);
        Task<List<Invoice>> GetInvoicesByCustomerIdAsync(int customerId);

        Task<Invoice?> GetInvoiceEntityByIdAsync(int id);
    }
}
