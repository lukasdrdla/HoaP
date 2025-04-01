using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Domain.Entities
{
    public class MealPlan : Entity<int>
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
