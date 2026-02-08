namespace HoaP.Domain.Entities
{
    public class RatePlan : AuditableEntity<int>
    {
        public string Name { get; set; } = string.Empty;
        public int? RoomTypeId { get; set; }
        public RoomType? RoomType { get; set; }
        public int? RoomId { get; set; }
        public Room? Room { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
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
