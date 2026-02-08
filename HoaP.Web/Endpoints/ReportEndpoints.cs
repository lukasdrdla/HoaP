using HoaP.Application.Services;
using HoaP.Application.ViewModels.Report;

namespace HoaP.Web.Endpoints
{
    public static class ReportEndpoints
    {
        public static void MapReportEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("/api/reports").RequireAuthorization();

            group.MapGet("/kpi", async (DateTime? startDate, DateTime? endDate, int? roomTypeId, ReportService service) =>
            {
                var filter = new ReportFilterViewModel
                {
                    StartDate = startDate ?? new DateTime(DateTime.Now.Year, 1, 1),
                    EndDate = endDate ?? DateTime.Now,
                    RoomTypeId = roomTypeId
                };
                var kpi = await service.GetKpiAsync(filter);
                return Results.Ok(kpi);
            });

            group.MapGet("/charts", async (DateTime? startDate, DateTime? endDate, string? granularity, ReportService service) =>
            {
                var filter = new ReportFilterViewModel
                {
                    StartDate = startDate ?? new DateTime(DateTime.Now.Year, 1, 1),
                    EndDate = endDate ?? DateTime.Now,
                    Granularity = granularity ?? "monthly"
                };
                var charts = await service.GetChartDataAsync(filter);
                return Results.Ok(charts);
            });
        }
    }
}
