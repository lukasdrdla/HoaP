using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels.Customer;
using HoaP.Domain.Entities;

namespace HoaP.Application.ViewModels
{
    public class ReservationViewModel
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; } = string.Empty;
        public DateTime CheckIn { get; set; } = DateTime.Now;
        public DateTime CheckOut { get; set; } = DateTime.Now.AddDays(3);
        public decimal TotalPrice { get; set; }
        public string ReservationStatusName { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string CurrencySymbol { get; set; } = "";

        public bool HasInvoice { get; set; }


        public int Guests { get; set; }

        public CustomerViewModel Customer { get; set; } = new();

    }
}
