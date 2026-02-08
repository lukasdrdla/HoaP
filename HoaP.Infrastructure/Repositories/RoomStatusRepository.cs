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
    public class RoomStatusRepository : IRoomStatusRepository
    {
        private readonly ApplicationDbContext _context;

        public RoomStatusRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateRoomStatusAsync(RoomStatus entity)
        {
            await _context.RoomStatuses.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRoomStatusAsync(int id)
        {
            var existing = await _context.RoomStatuses.FindAsync(id);
            if (existing != null)
            {
                _context.RoomStatuses.Remove(existing);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<RoomStatus?> GetRoomStatusByIdAsync(int id)
        {
            return await _context.RoomStatuses.FindAsync(id);
        }

        public async Task<List<RoomStatus>> GetRoomStatusesAsync()
        {
            return await _context.RoomStatuses.AsNoTracking().ToListAsync();
        }

        public async Task UpdateRoomStatusAsync(RoomStatus entity)
        {
            _context.RoomStatuses.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
