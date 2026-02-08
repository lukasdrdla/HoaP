namespace HoaP.Application.ViewModels.Report
{
    public class ChartDataPointViewModel
    {
        public string Label { get; set; } = string.Empty;
        public decimal Value { get; set; }
    }

    public class ReportChartViewModel
    {
        public List<ChartDataPointViewModel> RevPARSeries { get; set; } = new();
        public List<ChartDataPointViewModel> ADRSeries { get; set; } = new();
        public List<ChartDataPointViewModel> OccupancySeries { get; set; } = new();
        public List<ChartDataPointViewModel> RevenueSeries { get; set; } = new();
        public List<RevenueBySourceViewModel> RevenueBySource { get; set; } = new();
        public List<RevenueByRoomTypeViewModel> RevenueByRoomType { get; set; } = new();
    }

    public class RevenueBySourceViewModel
    {
        public string SourceName { get; set; } = string.Empty;
        public decimal Revenue { get; set; }
        public int ReservationCount { get; set; }
    }

    public class RevenueByRoomTypeViewModel
    {
        public string RoomTypeName { get; set; } = string.Empty;
        public decimal Revenue { get; set; }
        public int RoomNightsSold { get; set; }
    }
}
