using System.ComponentModel.DataAnnotations;

namespace HoaP.Application.ViewModels.RatePlan
{
    public class RatePlanFormViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Název je povinný.")]
        [MaxLength(100, ErrorMessage = "Název může mít maximálně 100 znaků.")]
        public string Name { get; set; } = string.Empty;

        public int? RoomTypeId { get; set; }
        public int? RoomId { get; set; }

        [Required(ErrorMessage = "Datum začátku je povinné.")]
        public DateTime StartDate { get; set; } = DateTime.Now.Date;

        [Required(ErrorMessage = "Datum konce je povinné.")]
        public DateTime EndDate { get; set; } = DateTime.Now.Date.AddMonths(3);

        [Required(ErrorMessage = "Cenový modifikátor je povinný.")]
        public decimal PriceModifier { get; set; }

        public bool IsPercentage { get; set; } = true;
        public int? MinNights { get; set; }
        public int? MaxNights { get; set; }

        public bool Monday { get; set; } = true;
        public bool Tuesday { get; set; } = true;
        public bool Wednesday { get; set; } = true;
        public bool Thursday { get; set; } = true;
        public bool Friday { get; set; } = true;
        public bool Saturday { get; set; } = true;
        public bool Sunday { get; set; } = true;

        public bool IsActive { get; set; } = true;
        public int Priority { get; set; } = 0;
    }
}
