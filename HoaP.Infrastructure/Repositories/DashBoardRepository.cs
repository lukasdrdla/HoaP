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
    public class DashBoardRepository : IDashBoardRepsoitory
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

            var revenue = await _context.Reservations
                .Where(r => r.CheckIn >= firstDayOfLastMonth && r.CheckIn <= lastDayOfLastMonth)
                .SumAsync(r => r.TotalPrice);

            return revenue;
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
