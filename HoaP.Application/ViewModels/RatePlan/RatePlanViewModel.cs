namespace HoaP.Application.ViewModels.RatePlan
{
    public class RatePlanViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? RoomTypeName { get; set; }
        public string? RoomNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal PriceModifier { get; set; }
        public bool IsPercentage { get; set; }
        public bool IsActive { get; set; }
        public int Priority { get; set; }
    }
}
