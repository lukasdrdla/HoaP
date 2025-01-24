using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels;

namespace HoaP.Application.Services
{
    public class ReservationStatusService
    {
        private readonly IReservationStatusRepository _reservationStatusRepository;

        public ReservationStatusService(IReservationStatusRepository reservationStatusRepository)
        {
            _reservationStatusRepository = reservationStatusRepository;
        }

        public async Task<List<ReservationStatusViewModel>> GetReservationStatusesAsync()
        {
            return await _reservationStatusRepository.GetReservationStatusesAsync();
        }

        public async Task<ReservationStatusViewModel> GetReservationStatusByIdAsync(int id)
        {
            return await _reservationStatusRepository.GetReservationStatusByIdAsync(id);
        }

        public async Task CreateReservationStatusAsync(ReservationStatusViewModel model)
        {
            await _reservationStatusRepository.CreateReservationStatusAsync(model);
        }

        public async Task UpdateReservationStatusAsync(ReservationStatusViewModel model)
        {
            await _reservationStatusRepository.UpdateReservationStatusAsync(model);
        }

        public async Task DeleteReservationStatusAsync(int id)
        {
            await _reservationStatusRepository.DeleteReservationStatusAsync(id);
        }
    }
}
