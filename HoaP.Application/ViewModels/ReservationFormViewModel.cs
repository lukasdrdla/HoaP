using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels.Currency;
using HoaP.Application.ViewModels.Customer;
using HoaP.Application.ViewModels.Room;
using HoaP.Application.ViewModels.ServiceR;
using HoaP.Domain.Entities;

namespace HoaP.Application.ViewModels
{
    public class ReservationFormViewModel
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckIn { get; set; } = DateTime.Now;
        public DateTime CheckOut { get; set; } = DateTime.Now.AddDays(3);
        public string RoomNumber { get; set; } = string.Empty;
        public string RoomTypeName { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public int CustomerId { get; set; }
        public int CurrencyId { get; set; }
        public int Adults { get; set; } = 1;
        public int Children { get; set; } = 0;
        public int MealPlanId { get; set; }
        public string SpecialRequest { get; set; } = string.Empty;
        public decimal TotalPrice { get; set; }
        public decimal OriginalMealPlanPrice { get; set; }
        public decimal MealPlanConvertedPrice { get; set; }


        public int ReservationStatusId { get; set; }
        public string AdminNote { get; set; } = string.Empty;
        public List<CustomerFormViewModel> Guests { get; set; } = new();
        public List<CurrencyViewModel> Currencies { get; set; } = new();
        public List<ServiceReservationViewModel> SelectedServices { get; set; } = new();


    }
}
