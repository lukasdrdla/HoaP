using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Application.ViewModels.DashBoard
{
    public class DashBoardViewModel
    {
        public int TotalCustomers { get; set; }
        public int TotalReservations { get; set; }
        public int TotalRooms { get; set; }
        public decimal RevenueFromLastMonth { get; set; }


    }
}
