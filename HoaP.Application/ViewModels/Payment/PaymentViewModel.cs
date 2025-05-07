using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Application.ViewModels.Payment
{
    public class PaymentViewModel
    {
        public Guid Id { get; set; }
        public string InvoiceNumber { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public string CurrencySymbol { get; set; } = string.Empty;
        public DateTime PaymentDate { get; set; }
        public string PaymentMethodName { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
    }

}
