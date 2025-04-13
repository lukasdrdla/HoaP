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
    }
}
