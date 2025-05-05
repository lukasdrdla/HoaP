using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Application.ViewModels.Currency
{
    public class CurrencyViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        [Required(ErrorMessage = "Název je povinný")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Symbol je povinný")]
        public string Symbol { get; set; } = string.Empty;
        [Required(ErrorMessage = "Kurz je povinný")]
        [Range(0.01, 1000000, ErrorMessage = "Kurz musí být mezi 0.01 a 1000000")]
        public decimal Rate { get; set; } = 1.0m;
    }
}
