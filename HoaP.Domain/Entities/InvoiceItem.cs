using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Domain.Entities
{
    public class InvoiceItem : Entity<int>
    {
        public int InvoiceId { get; set; }
        public Invoice? Invoice { get; set; }

        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; } = 1;
        public decimal UnitPrice { get; set; }
        public decimal Price { get; set; }
        public decimal VatRate { get; set; } = 21m;
    }
}
