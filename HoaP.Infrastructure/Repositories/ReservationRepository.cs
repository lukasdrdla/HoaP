using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ReservationRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task CreateReservationAsync(ReservationFormViewModel reservation)
        {
            var newReservation = _mapper.Map<Reservation>(reservation);
            await _context.Reservations.AddAsync(newReservation);
            await _context.SaveChangesAsync();
        }

        public async Task CancelReservationAsync(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation != null)
            {
                reservation.IsCanceled = true;
                reservation.ReservationStatusId = 2;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<DetailReservationViewModel> GetReservationByIdAsync(int id)
        {
            var reservation = await _context.Reservations
                .Include(r => r.ReservationStatus)
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .ThenInclude(r => r.RoomType)
                .Include(r => r.Guests)
                .FirstOrDefaultAsync(r => r.Id == id);

            return _mapper.Map<DetailReservationViewModel>(reservation);
        }

        public async Task<List<ReservationViewModel>> GetReservationsAsync()
        {
            var reservations = await _context.Reservations
                .Include(r => r.ReservationStatus)
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .ToListAsync();
            return _mapper.Map<List<ReservationViewModel>>(reservations);
        }

        public async Task<List<ReservationViewModel>> GetReservationsByCustomerIdAsync(int customerId)
        {
            var reservation = await _context.Reservations
                .Include(r => r.ReservationStatus)
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .Where(r => r.CustomerId == customerId)
                .ToListAsync();
            return _mapper.Map<List<ReservationViewModel>>(reservation);
        }

        public async Task<List<ReservationViewModel>> GetReservationsByRoomIdAsync(int roomId)
        {
            var reservations = await _context.Reservations
                .Include(r => r.ReservationStatus)
                .Include(r => r.Customer)
                .Where(r => r.RoomId == roomId)
                .ToListAsync();
            return _mapper.Map<List<ReservationViewModel>>(reservations);

        }

        public async Task UpdateReservationAsync(ReservationFormViewModel reservation)
        {
            var existingReservation = await _context.Reservations.FindAsync(reservation.Id);

            if (existingReservation != null)
            {
                _mapper.Map(reservation, existingReservation);
                _context.Reservations.Update(existingReservation);
                await _context.SaveChangesAsync();
            }
        }
    }
}
