using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Application.ViewModels.MealPlan
{
    public class MealPlanViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Název je povinný")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Cena je povinná")]
        [Range(0, 1000000, ErrorMessage = "Cena musí být mezi 0 a 1000000")]
        public decimal Price { get; set; }
    }
}
