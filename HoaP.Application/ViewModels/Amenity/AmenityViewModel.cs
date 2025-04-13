using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Application.ViewModels.Amenity
{
    public class AmenityViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Název je povinný")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Ikonka je povinná")]
        public string Icon { get; set; } = string.Empty;

        public bool isSelected { get; set; }
    }
}
