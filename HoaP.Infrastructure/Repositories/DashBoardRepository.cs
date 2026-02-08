using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class DashBoardRepository : IDashBoardRepository
    {
        private readonly ApplicationDbContext _context;

        public DashBoardRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<decimal> GetRevenueFromLastMonthAsync()
        {
            var firstDayOfLastMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(-1);
            var lastDayOfLastMonth = firstDayOfLastMonth.AddMonths(1).AddDays(-1);

            var reservations = await _context.Reservations
                .AsNoTracking()
                .Include(r => r.Currency)
                .Where(r => r.CheckIn >= firstDayOfLastMonth && r.CheckIn <= lastDayOfLastMonth)
                .Where(r => !r.IsCanceled)
                .Select(r => new { r.TotalPrice, Rate = r.Currency != null ? r.Currency.Rate : 1m })
                .ToListAsync();

            return reservations.Sum(r => r.TotalPrice * r.Rate);
        }

        public async Task<int> GetTotalBookingsAsync()
        {
            var reservations = await _context.Reservations.CountAsync();
            return reservations;

        }

        public async Task<int> GetTotalCustomersAsync()
        {
            var customers = await _context.Customers.CountAsync();
            return customers;
        }

        public async Task<int> GetTotalRoomsAsync()
        {
            var rooms = await _context.Rooms.CountAsync();
            return rooms;
        }
    }
}
