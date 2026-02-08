namespace HoaP.Application.ViewModels.Report
{
    public class KpiViewModel
    {
        public decimal RevPAR { get; set; }
        public decimal ADR { get; set; }
        public decimal OccupancyRate { get; set; }
        public decimal TotalRevenue { get; set; }
        public int TotalRoomNightsSold { get; set; }
        public int TotalAvailableRoomNights { get; set; }
    }
}
