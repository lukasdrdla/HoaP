﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IReservationRepository
    {
        Task<List<ReservationViewModel>> GetReservationsAsync();
        Task<DetailReservationViewModel> GetReservationByIdAsync(int id);
        Task CreateReservationAsync(Reservation reservation);
        Task UpdateReservationAsync(Reservation reservation);
        Task DeleteReservationAsync(int id);

        Task<List<ReservationViewModel>> GetReservationsByCustomerIdAsync(int customerId);
        Task<List<ReservationViewModel>> GetReservationsByRoomIdAsync(int roomId);

    }
}
