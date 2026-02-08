namespace HoaP.Application.ViewModels.Report
{
    public class ReportFilterViewModel
    {
        public DateTime StartDate { get; set; } = new DateTime(DateTime.Now.Year, 1, 1);
        public DateTime EndDate { get; set; } = DateTime.Now;
        public int? RoomTypeId { get; set; }
        public string Granularity { get; set; } = "monthly";
    }
}
