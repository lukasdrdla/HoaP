using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Application.ViewModels.Invoice
{
    public class InvoiceItemViewModel
    {
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }

}
