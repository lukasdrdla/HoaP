using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IReservationStatusRepository
    {
        Task<List<ReservationStatus>> GetReservationStatusesAsync();
        Task<ReservationStatus?> GetReservationStatusByIdAsync(int id);
        Task CreateReservationStatusAsync(ReservationStatus entity);
        Task UpdateReservationStatusAsync(ReservationStatus entity);
        Task DeleteReservationStatusAsync(int id);
    }
}
