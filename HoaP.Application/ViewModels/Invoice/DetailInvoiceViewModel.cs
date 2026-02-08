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
        public string InvoiceNumber { get; set; } = string.Empty;
        public int ReservationId { get; set; }
        public string CurrencyName { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerAddress { get; set; } = string.Empty;
        public string CustomerCity { get; set; } = string.Empty;
        public string CustomerPostalCode { get; set; } = string.Empty;
        public string CustomerCountry { get; set; } = string.Empty;
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? DateOfTaxableSupply { get; set; }
        public decimal Price { get; set; }
        public bool IsPaid { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Discount { get; set; }
        public decimal Prepayment { get; set; }
        public bool IsCanceled { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public string VariableSymbol { get; set; } = string.Empty;
        public string BankAccount { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public decimal ReservationTotal { get; set; }
        public string? CurrencySymbol { get; set; }

        public int CurrencyId { get; set; }

        public List<InvoiceItemViewModel> Items { get; set; } = new();




    }

}
