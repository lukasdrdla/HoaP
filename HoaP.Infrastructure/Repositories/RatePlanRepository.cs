using HoaP.Application.Interfaces;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class RatePlanRepository : IRatePlanRepository
    {
        private readonly ApplicationDbContext _context;

        public RatePlanRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<RatePlan>> GetRatePlansAsync()
        {
            return await _context.RatePlans
                .AsNoTracking()
                .Include(rp => rp.RoomType)
                .Include(rp => rp.Room)
                .OrderByDescending(rp => rp.Priority)
                .ThenBy(rp => rp.StartDate)
                .ToListAsync();
        }

        public async Task<RatePlan?> GetRatePlanByIdAsync(int id)
        {
            return await _context.RatePlans
                .Include(rp => rp.RoomType)
                .Include(rp => rp.Room)
                .FirstOrDefaultAsync(rp => rp.Id == id);
        }

        public async Task CreateRatePlanAsync(RatePlan ratePlan)
        {
            ratePlan.CreatedAt = DateTime.Now;
            ratePlan.UpdatedAt = DateTime.Now;
            await _context.RatePlans.AddAsync(ratePlan);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRatePlanAsync(RatePlan ratePlan)
        {
            var existing = await _context.RatePlans.FindAsync(ratePlan.Id)
                ?? throw new Exception("Cenový plán nebyl nalezen.");

            _context.Entry(existing).CurrentValues.SetValues(ratePlan);
            existing.UpdatedAt = DateTime.Now;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRatePlanAsync(int id)
        {
            var ratePlan = await _context.RatePlans.FindAsync(id)
                ?? throw new Exception("Cenový plán nebyl nalezen.");

            _context.RatePlans.Remove(ratePlan);
            await _context.SaveChangesAsync();
        }

        public async Task<List<RatePlan>> GetActiveRatePlansForDateRangeAsync(
            DateTime startDate, DateTime endDate, int? roomTypeId = null, int? roomId = null)
        {
            return await _context.RatePlans
                .AsNoTracking()
                .Where(rp => rp.IsActive
                    && rp.StartDate <= endDate
                    && rp.EndDate >= startDate
                    && (rp.RoomTypeId == null || rp.RoomTypeId == roomTypeId)
                    && (rp.RoomId == null || rp.RoomId == roomId))
                .OrderByDescending(rp => rp.Priority)
                .ToListAsync();
        }
    }
}
