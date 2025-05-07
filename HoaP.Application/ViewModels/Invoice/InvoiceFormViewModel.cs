using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels.Currency;

namespace HoaP.Application.ViewModels.Invoice
{
    public class InvoiceFormViewModel
    {

        public int? Id { get; set; }

        public List<int> ReservationIds { get; set; } = new();

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

        public string? UserId { get; set; } 

        [Required]
        public int CurrencyId { get; set; }

        public List<ReservationViewModel> Reservations { get; set; } = new();

        public List<CurrencyViewModel> Currencies { get; set; } = new();

        public List<InvoiceItemViewModel> Items { get; set; } = new();



    }

}
