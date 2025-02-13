using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Domain.Entities
{
    public class Reservation : AuditableEntity
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckIn { get; set; } = DateTime.Now;
        public DateTime CheckOut { get; set; } = DateTime.Now.AddDays(3);
        public decimal TotalPrice { get; set; }
        public int ReservationStatusId { get; set; }
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public int Adults { get; set; }
        public int Children { get; set; }
        public int MealPlanId { get; set; }
        public string SpecialRequest { get; set; } = "";
        public string AdminNote { get; set; } = "";
        

        public Room? Room { get; set; }
        public ReservationStatus? ReservationStatus { get; set; }
        public MealPlan? MealPlan { get; set; }

        public ICollection<Guest> Guests { get; set; } = null!;
    }
}
