using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Application.ViewModels.ServiceR
{
    public class ServiceReservationFormModel
    {
        public int ServiceId { get; set; }
        public int Quantity { get; set; } = 1;
        public decimal UnitPrice { get; set; }
        public string? Note { get; set; } = string.Empty;
    }
}
