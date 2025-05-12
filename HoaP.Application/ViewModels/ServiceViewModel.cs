using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Application.ViewModels
{
    public class ServiceViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Název služby je povinný.")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Cena služby je povinná.")]
        [Range(0, 1000000, ErrorMessage = "Cena služby musí být mezi 0 a 1000000.")]
        public decimal Price { get; set; }
        public string? Description { get; set; } = string.Empty;
        public bool IsPerNight { get; set; }
        public bool IsPerPerson { get; set; }
        public bool IsOneTime { get; set; }

    }
}
