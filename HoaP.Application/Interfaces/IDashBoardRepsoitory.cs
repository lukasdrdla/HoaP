using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Application.Interfaces
{
    public interface IDashBoardRepsoitory
    {
        Task<int> GetTotalCustomersAsync();
        Task<int> GetTotalRoomsAsync();
        Task<int> GetTotalBookingsAsync();
        Task<decimal> GetRevenueFromLastMonthAsync();
    }
}
