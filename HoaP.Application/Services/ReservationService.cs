using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels;

namespace HoaP.Application.Services
{
    public class ReservationService
    {
        private readonly IReservationRepository _reservationRepository;

        public ReservationService(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task<List<ReservationViewModel>> GetReservationsByRoomIdAsync(int roomId)
        {
            return await _reservationRepository.GetReservationsByRoomIdAsync(roomId);
        }

        public async Task<List<ReservationViewModel>> GetReservationsByCustomerIdAsync(int customerId)
        {
            return await _reservationRepository.GetReservationsByCustomerIdAsync(customerId);
        }

        public async Task<List<ReservationViewModel>> GetReservationsAsync()
        {
            return await _reservationRepository.GetReservationsAsync();
        }

        public async Task<DetailReservationViewModel> GetReservationByIdAsync(int id)
        {
            return await _reservationRepository.GetReservationByIdAsync(id);
        }

        public async Task DeleteReservationAsync(int id)
        {
            await _reservationRepository.DeleteReservationAsync(id);
        }


    }
}
