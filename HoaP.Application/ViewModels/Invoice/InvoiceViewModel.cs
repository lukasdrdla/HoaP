using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Domain.Entities;

namespace HoaP.Application.ViewModels.Invoice
{
    public class InvoiceViewModel
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public string CurrencyName { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public DateTime IssueDate { get; set; } = DateTime.Now;
        public DateTime DueDate { get; set; } = DateTime.Now.AddDays(14);
        public decimal Price { get; set; }
        public bool IsPaid { get; set; } = false;
    }
}
