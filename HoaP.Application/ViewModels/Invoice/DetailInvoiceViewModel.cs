using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Application.ViewModels.Invoice
{
    public class DetailInvoiceViewModel
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public string CurrencyName { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Price { get; set; }
        public bool IsPaid { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Discount { get; set; }
        public decimal Prepayment { get; set; }
        public bool IsCanceled { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public int CurrencyId { get; set; }

    }

}
