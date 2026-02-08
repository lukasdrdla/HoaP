using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class ReservationStatusRepository : IReservationStatusRepository
    {
        private readonly ApplicationDbContext _context;

        public ReservationStatusRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateReservationStatusAsync(ReservationStatus entity)
        {
            await _context.ReservationStatuses.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteReservationStatusAsync(int id)
        {
            var existing = await _context.ReservationStatuses.FindAsync(id);
            if (existing != null)
            {
                _context.ReservationStatuses.Remove(existing);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<ReservationStatus?> GetReservationStatusByIdAsync(int id)
        {
            return await _context.ReservationStatuses.FindAsync(id);
        }

        public async Task<List<ReservationStatus>> GetReservationStatusesAsync()
        {
            return await _context.ReservationStatuses.AsNoTracking().ToListAsync();
        }

        public async Task UpdateReservationStatusAsync(ReservationStatus entity)
        {
            _context.ReservationStatuses.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
