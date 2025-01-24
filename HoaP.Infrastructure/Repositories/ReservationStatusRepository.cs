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
    public class ReservationStatusRepository : IReservationStatusRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ReservationStatusRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateReservationStatusAsync(ReservationStatusViewModel model)
        {
            await _context.ReservationStatuses.AddAsync(_mapper.Map<ReservationStatus>(model));
            await _context.SaveChangesAsync();
        }

        public async Task DeleteReservationStatusAsync(int id)
        {
            var existingReservationStatus = await _context.ReservationStatuses.FindAsync(id);

            if (existingReservationStatus != null)
            {
                _context.ReservationStatuses.Remove(existingReservationStatus);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<ReservationStatusViewModel> GetReservationStatusByIdAsync(int id)
        {
            var reservationStatus = await _context.ReservationStatuses.FindAsync(id);
            if (reservationStatus != null)
            {
                return _mapper.Map<ReservationStatusViewModel>(reservationStatus);
            }
            return null;
        }

        public async Task<List<ReservationStatusViewModel>> GetReservationStatusesAsync()
        {
            var reservationStatuses = await _context.ReservationStatuses.ToListAsync();
            return _mapper.Map<List<ReservationStatusViewModel>>(reservationStatuses);
        }

        public async Task UpdateReservationStatusAsync(ReservationStatusViewModel model)
        {
            var existingReservationStatus = await _context.ReservationStatuses.FindAsync(model.Id);

            if (existingReservationStatus != null)
            {
                _mapper.Map(model, existingReservationStatus);
                _context.ReservationStatuses.Update(existingReservationStatus);
                await _context.SaveChangesAsync();
            }
        }
    }
}
