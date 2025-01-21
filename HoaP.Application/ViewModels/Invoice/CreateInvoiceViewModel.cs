using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Application.ViewModels.Invoice
{
    public class CreateInvoiceViewModel
    {
        [Required]
        public int ReservationId { get; set; }

        [Required]
        public int CurrencyId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime IssueDate { get; set; } = DateTime.Now;

        [Required]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; } = DateTime.Now.AddDays(14);

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive value.")]
        public decimal Price { get; set; }

        public string Description { get; set; } = string.Empty;

        [Range(0, 100, ErrorMessage = "Discount must be between 0 and 100.")]
        public decimal Discount { get; set; } = 0.0m;

        [Range(0, double.MaxValue, ErrorMessage = "Prepayment must be a positive value.")]
        public decimal Prepayment { get; set; } = 0.0m;
    }

}
