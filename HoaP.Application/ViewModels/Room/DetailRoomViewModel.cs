using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels.Review;
using HoaP.Domain.Entities;

namespace HoaP.Application.ViewModels.Room
{
    public class DetailRoomViewModel
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; } = string.Empty;
        public string RoomStatusName { get; set; } = string.Empty;
        public string RoomTypeName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public byte[]? Image { get; set; }
        public bool IsDisable { get; set; } = false;
        public int MaxAdults { get; set; }
        public int MaxChildren { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public string? CurrencySymbol { get; set; }
        public int? CurrencyId { get; set; }

        public int RoomStatusId { get; set; }
        public int RoomTypeId { get; set; }
        public ICollection<ReviewViewModel> Reviews { get; set; } = new List<ReviewViewModel>();
    }
}
