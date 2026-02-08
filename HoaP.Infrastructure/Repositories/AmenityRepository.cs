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
    public class AmenityRepository : IAmenityRepository
    {
        private readonly ApplicationDbContext _context;

        public AmenityRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAmenityAsync(Amenity entity)
        {
            await _context.Amenities.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAmenityAsync(int id)
        {
            var existing = await _context.Amenities.FindAsync(id);
            if (existing != null)
            {
                _context.Amenities.Remove(existing);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Amenity>> GetAmenitiesAsync()
        {
            return await _context.Amenities.AsNoTracking().ToListAsync();
        }

        public async Task<List<Amenity>> GetAmenitiesByRoomIdAsync(int roomId)
        {
            return await _context.RoomAmenities
                .AsNoTracking()
                .Where(ra => ra.RoomId == roomId)
                .Include(ra => ra.Amenity)
                .Select(ra => ra.Amenity)
                .ToListAsync();
        }

        public async Task<Amenity?> GetAmenityByIdAsync(int id)
        {
            return await _context.Amenities.FindAsync(id);
        }

        public async Task UpdateAmenityAsync(Amenity entity)
        {
            _context.Amenities.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
