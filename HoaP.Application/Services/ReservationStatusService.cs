using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels;
using HoaP.Domain.Entities;

namespace HoaP.Application.Services
{
    public class ReservationStatusService
    {
        private readonly IReservationStatusRepository _reservationStatusRepository;
        private readonly IMapper _mapper;

        public ReservationStatusService(IReservationStatusRepository reservationStatusRepository, IMapper mapper)
        {
            _reservationStatusRepository = reservationStatusRepository;
            _mapper = mapper;
        }

        public async Task<List<ReservationStatusViewModel>> GetReservationStatusesAsync()
        {
            var entities = await _reservationStatusRepository.GetReservationStatusesAsync();
            return _mapper.Map<List<ReservationStatusViewModel>>(entities);
        }

        public async Task<ReservationStatusViewModel> GetReservationStatusByIdAsync(int id)
        {
            var entity = await _reservationStatusRepository.GetReservationStatusByIdAsync(id);
            return _mapper.Map<ReservationStatusViewModel>(entity);
        }

        public async Task CreateReservationStatusAsync(ReservationStatusViewModel model)
        {
            var entity = _mapper.Map<ReservationStatus>(model);
            await _reservationStatusRepository.CreateReservationStatusAsync(entity);
        }

        public async Task UpdateReservationStatusAsync(ReservationStatusViewModel model)
        {
            var entity = _mapper.Map<ReservationStatus>(model);
            await _reservationStatusRepository.UpdateReservationStatusAsync(entity);
        }

        public async Task DeleteReservationStatusAsync(int id)
        {
            await _reservationStatusRepository.DeleteReservationStatusAsync(id);
        }
    }
}
