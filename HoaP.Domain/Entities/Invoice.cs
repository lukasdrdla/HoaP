using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Domain.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public int CurrencyId { get; set; }
        public DateTime IssueDate { get; set; } = DateTime.Now;
        public DateTime DueDate { get; set; } = DateTime.Now.AddDays(14);
        public decimal Price { get; set; }
        public bool IsPaid { get; set; } = false;
        public string Description { get; set; } = string.Empty;
        public decimal Discount { get; set; } = 0.0m;
        public decimal Prepayment { get; set; } = 0.0m;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public Reservation? Reservation { get; set; }
        public Currency? Currency { get; set; }
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
