using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Domain.Entities
{
    public class ServiceReservation : AuditableEntity<int>
    {

        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }

        public int Quantity { get; set; } = 1;
    }
}
