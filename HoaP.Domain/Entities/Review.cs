using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Domain.Entities
{
    public class Review : AuditableEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int RoomId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
        public Room? Room { get; set; }
        public Customer? Customer { get; set; }
    }
}
