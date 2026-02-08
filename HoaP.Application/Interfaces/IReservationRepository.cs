using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IReservationRepository
    {
        Task<List<Reservation>> GetReservationsAsync();
        Task<Reservation?> GetReservationByIdAsync(int id);
        Task CreateReservationAsync(Reservation reservation, List<Customer> guestsToUpdate);
        Task UpdateReservationAsync(Reservation reservation);
        Task DeleteReservationAsync(int id);
        Task UpdateReservationStatusAsync(int id, int statusId, bool? isCanceled = null);

        Task<bool> IsRoomAvailableAsync(int roomId, DateTime checkIn, DateTime checkOut, int? excludeReservationId = null);
        Task<bool> HasInvoiceAsync(int id);
        Task<int?> GetReservationStatusIdAsync(int id);

        Task<List<Reservation>> GetReservationsByCustomerIdAsync(int customerId);
        Task<List<Reservation>> GetReservationsByRoomIdAsync(int roomId);
        Task<List<Reservation>> GetReservationsByDateRangeAsync(DateTime from, DateTime to);
    }
}
