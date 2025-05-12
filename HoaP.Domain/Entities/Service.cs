using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Domain.Entities
{
    public class Service : Entity<int>
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string? Description { get; set; } = string.Empty;
        public bool IsPerNight { get; set; }
        public bool IsPerPerson { get; set; }
        public bool IsOneTime { get; set; }
    }

}
