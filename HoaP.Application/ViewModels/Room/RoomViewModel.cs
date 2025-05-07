using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Domain.Entities;

namespace HoaP.Application.ViewModels.Room
{
    public class RoomViewModel
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; } = string.Empty;
        public string RoomTypeName { get; set; } = string.Empty;
        public string RoomStatusName { get; set; } = string.Empty;
        public bool IsDisable { get; set; } = false;
        public decimal Price { get; set; }
        public string CurrencySymbol { get; set; }
        public int MaxAdults { get; set; }
        public int MaxChildren { get; set; }
    }
}
