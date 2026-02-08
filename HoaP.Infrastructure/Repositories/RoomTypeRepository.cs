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
    public class RoomTypeRepository : IRoomTypeRepository
    {
        private readonly ApplicationDbContext _context;

        public RoomTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateRoomTypeAsync(RoomType entity)
        {
            await _context.RoomTypes.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRoomTypeAsync(int id)
        {
            var existing = await _context.RoomTypes.FindAsync(id);
            if (existing != null)
            {
                _context.RoomTypes.Remove(existing);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<RoomType?> GetRoomTypeByIdAsync(int id)
        {
            return await _context.RoomTypes.FindAsync(id);
        }

        public async Task<List<RoomType>> GetRoomTypesAsync()
        {
            return await _context.RoomTypes.AsNoTracking().ToListAsync();
        }

        public async Task UpdateRoomTypeAsync(RoomType entity)
        {
            _context.RoomTypes.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
