using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Domain.Entities
{
    public class ReservationCustomer : AuditableEntity<int>
    {
        public int ReservationId { get; set; }
        public Reservation? Reservation { get; set; }

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public bool IsMainGuest { get; set; }
    }
}
