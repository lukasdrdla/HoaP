using HoaP.Application.Interfaces;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly ApplicationDbContext _context;

        public ReportRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> GetTotalRoomCountAsync()
        {
            return await _context.Rooms.CountAsync(r => !r.IsDisable);
        }

        public async Task<List<Reservation>> GetReservationsForReportAsync(DateTime startDate, DateTime endDate)
        {
            return await _context.Reservations
                .AsNoTracking()
                .Include(r => r.Room)
                    .ThenInclude(room => room!.RoomType)
                .Include(r => r.Currency)
                .Include(r => r.ReservationSource)
                .Where(r => !r.IsCanceled
                    && r.CheckIn < endDate
                    && r.CheckOut > startDate)
                .ToListAsync();
        }
    }
}
