using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;

namespace HoaP.Application.Services
{
    public class DashBoardService
    {
        private readonly IDashBoardRepsoitory _dashBoardRepsoitory;

        public DashBoardService(IDashBoardRepsoitory dashBoardRepsoitory)
        {
            _dashBoardRepsoitory = dashBoardRepsoitory;
        }

        public async Task<int> GetTotalCustomers()
        {
            return await _dashBoardRepsoitory.GetTotalCustomersAsync();
        }

        public async Task<int> GetTotalReservations()
        {
            return await _dashBoardRepsoitory.GetTotalBookingsAsync();
        }

        public async Task<int> GetTotalRooms()
        {
            return await _dashBoardRepsoitory.GetTotalRoomsAsync();
        }

        public async Task<decimal> GetRevenueFromLastMonth()
        {
            return await _dashBoardRepsoitory.GetRevenueFromLastMonthAsync();
        }




    }
}
