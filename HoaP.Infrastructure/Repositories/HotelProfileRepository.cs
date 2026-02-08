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
    public class HotelProfileRepository : IHotelProfileRepository
    {
        private readonly ApplicationDbContext _context;

        public HotelProfileRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<HotelProfile?> GetHotelProfileAsync()
        {
            return await _context.HotelProfiles
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        public async Task SaveHotelProfileAsync(HotelProfile entity)
        {
            var existing = await _context.HotelProfiles.FirstOrDefaultAsync();

            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(entity);
                existing.UpdatedAt = DateTime.Now;
            }
            else
            {
                await _context.HotelProfiles.AddAsync(entity);
            }

            await _context.SaveChangesAsync();
        }
    }
}
