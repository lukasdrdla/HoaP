using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels.Guest;
using HoaP.Application.ViewModels.MealPlan;
using HoaP.Domain.Entities;

namespace HoaP.Application.ViewModels
{
    public class DetailReservationViewModel
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; } = string.Empty;
        public string RoomTypeName { get; set; } = string.Empty;
        public int RoomTypeId { get; set; }
        public int ReservationStatusId { get; set; }
        public int MealPlanId { get; set; }
        public int RoomId { get; set; }
        public string RoomImage { get; set; } = string.Empty;
        public int GuestCount { get; set; }
        public DateTime CheckIn { get; set; } = DateTime.Now;
        public DateTime CheckOut { get; set; } = DateTime.Now.AddDays(3);
        public decimal TotalPrice { get; set; }
        public string ReservationStatusName { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public int Adults { get; set; }
        public int Children { get; set; }
        public string MealPlanName { get; set; } = string.Empty;
        public string SpecialRequest { get; set; } = "";
        public string AdminNote { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public ICollection<GuestViewModel> Guests { get; set; } = null!;

    }
}
