using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Application.ViewModels.Amenity
{
    public class AmenityViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;

        public bool isSelected { get; set; }
    }
}
