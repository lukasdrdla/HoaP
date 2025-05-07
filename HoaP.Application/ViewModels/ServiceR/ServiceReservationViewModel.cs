using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Application.ViewModels.ServiceR
{
    public class ServiceReservationViewModel
    {
        public int ServiceId { get; set; }
        public string? ServiceName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal OriginalUnitPrice { get; set; }
        public string? Note { get; set; }
        public bool IsPerNight { get; set; }

    }
}
