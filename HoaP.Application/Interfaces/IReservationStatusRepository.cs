using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels;

namespace HoaP.Application.Interfaces
{
    public interface IReservationStatusRepository
    {
        Task<List<ReservationStatusViewModel>> GetReservationStatusesAsync();
        Task<ReservationStatusViewModel> GetReservationStatusByIdAsync(int id);
        Task CreateReservationStatusAsync(ReservationStatusViewModel model);
        Task UpdateReservationStatusAsync(ReservationStatusViewModel model);
        Task DeleteReservationStatusAsync(int id);
    }
}
