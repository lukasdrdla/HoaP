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

        [Required(ErrorMessage = "Datum vystavení je povinné.")]
        [DataType(DataType.Date, ErrorMessage = "Zadejte platné datum vystavení.")]
        public DateTime IssueDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Datum splatnosti je povinné.")]
        [DataType(DataType.Date, ErrorMessage = "Zadejte platné datum splatnosti.")]
        public DateTime DueDate { get; set; } = DateTime.Now.AddDays(14);

        [Required(ErrorMessage = "Cena je povinná.")]
        [Range(0, double.MaxValue, ErrorMessage = "Cena musí být kladná hodnota.")]
        public decimal Price { get; set; }

        public string Description { get; set; } = string.Empty;

        [Range(0, 100, ErrorMessage = "Sleva musí být v rozmezí 0 až 100 %.")]
        public decimal Discount { get; set; } = 0.0m;

        [Range(0, double.MaxValue, ErrorMessage = "Záloha musí být kladná hodnota.")]
        public decimal Prepayment { get; set; } = 0.0m;

        public string? UserId { get; set; }

        [Required(ErrorMessage = "Vyberte měnu.")]
        public int CurrencyId { get; set; }

        public string? CurrencySymbol { get; set; }

        public List<ReservationViewModel> Reservations { get; set; } = new();
        public List<CurrencyViewModel> Currencies { get; set; } = new();
        public List<InvoiceItemViewModel> Items { get; set; } = new();
    }

}
