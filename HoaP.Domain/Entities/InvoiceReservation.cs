using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Domain.Interfaces;

namespace HoaP.Domain.Entities
{
    public class InvoiceReservation : AuditableEntity<int>
    {
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; } = null!;

        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; } = null!;
    }
}
