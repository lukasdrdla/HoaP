using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Domain.Entities
{
    public class Reservation : AuditableEntity<int>
    {
        public int RoomId { get; set; }
        public DateTime CheckIn { get; set; } = DateTime.Now;
        public DateTime CheckOut { get; set; } = DateTime.Now.AddDays(3);
        public decimal TotalPrice { get; set; }
        public int ReservationStatusId { get; set; }
        public int CurrencyId { get; set; }
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public int Adults { get; set; }
        public int Children { get; set; }
        public int MealPlanId { get; set; }
        public string SpecialRequest { get; set; } = "";
        public string AdminNote { get; set; } = "";
        public bool IsCanceled { get; set; } = false;


        public Room? Room { get; set; }
        public ReservationStatus? ReservationStatus { get; set; }
        public MealPlan? MealPlan { get; set; }
        public Currency? Currency { get; set; }

        public ICollection<ReservationCustomer> ReservationCustomers { get; set; } = new List<ReservationCustomer>();
        public ICollection<InvoiceReservation> InvoiceReservations { get; set; } = new List<InvoiceReservation>();

    }
}
