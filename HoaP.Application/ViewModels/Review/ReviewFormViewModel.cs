using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Application.ViewModels.Review
{
    public class ReviewFormViewModel
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;

    }
}
