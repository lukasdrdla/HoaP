using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Report;
using HoaP.Domain.Entities;

namespace HoaP.Application.Services
{
    public class ReportService
    {
        private readonly IReportRepository _reportRepository;

        public ReportService(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }

        public async Task<KpiViewModel> GetKpiAsync(ReportFilterViewModel filter)
        {
            var totalRooms = await _reportRepository.GetTotalRoomCountAsync();
            var reservations = await _reportRepository.GetReservationsForReportAsync(filter.StartDate, filter.EndDate);

            var totalDays = (int)(filter.EndDate.Date - filter.StartDate.Date).TotalDays;
            if (totalDays <= 0) totalDays = 1;

            var totalAvailableRoomNights = totalRooms * totalDays;
            var roomNightsSold = 0;
            decimal totalRevenue = 0;

            foreach (var r in reservations)
            {
                var overlapStart = r.CheckIn > filter.StartDate ? r.CheckIn : filter.StartDate;
                var overlapEnd = r.CheckOut < filter.EndDate ? r.CheckOut : filter.EndDate;
                var nights = (int)(overlapEnd.Date - overlapStart.Date).TotalDays;
                if (nights <= 0) continue;

                roomNightsSold += nights;

                var currencyRate = r.Currency?.Rate ?? 1m;
                var totalNightsOfReservation = (int)(r.CheckOut.Date - r.CheckIn.Date).TotalDays;
                if (totalNightsOfReservation <= 0) totalNightsOfReservation = 1;
                var dailyRevenue = (r.TotalPrice * currencyRate) / totalNightsOfReservation;
                totalRevenue += dailyRevenue * nights;
            }

            return new KpiViewModel
            {
                TotalAvailableRoomNights = totalAvailableRoomNights,
                TotalRoomNightsSold = roomNightsSold,
                TotalRevenue = Math.Round(totalRevenue, 2),
                RevPAR = totalAvailableRoomNights > 0 ? Math.Round(totalRevenue / totalAvailableRoomNights, 2) : 0,
                ADR = roomNightsSold > 0 ? Math.Round(totalRevenue / roomNightsSold, 2) : 0,
                OccupancyRate = totalAvailableRoomNights > 0 ? Math.Round((decimal)roomNightsSold / totalAvailableRoomNights * 100, 1) : 0
            };
        }

        public async Task<ReportChartViewModel> GetChartDataAsync(ReportFilterViewModel filter)
        {
            var totalRooms = await _reportRepository.GetTotalRoomCountAsync();
            var reservations = await _reportRepository.GetReservationsForReportAsync(filter.StartDate, filter.EndDate);

            var chart = new ReportChartViewModel();
            var periods = GeneratePeriods(filter.StartDate, filter.EndDate, filter.Granularity);

            foreach (var (periodStart, periodEnd, label) in periods)
            {
                var totalDays = (int)(periodEnd - periodStart).TotalDays;
                if (totalDays <= 0) totalDays = 1;
                var available = totalRooms * totalDays;
                var sold = 0;
                decimal revenue = 0;

                foreach (var r in reservations)
                {
                    var overlapStart = r.CheckIn > periodStart ? r.CheckIn : periodStart;
                    var overlapEnd = r.CheckOut < periodEnd ? r.CheckOut : periodEnd;
                    var nights = (int)(overlapEnd.Date - overlapStart.Date).TotalDays;
                    if (nights <= 0) continue;

                    sold += nights;
                    var totalNights = (int)(r.CheckOut.Date - r.CheckIn.Date).TotalDays;
                    if (totalNights <= 0) totalNights = 1;
                    var currencyRate = r.Currency?.Rate ?? 1m;
                    revenue += (r.TotalPrice * currencyRate / totalNights) * nights;
                }

                chart.RevenueSeries.Add(new ChartDataPointViewModel { Label = label, Value = Math.Round(revenue, 0) });
                chart.RevPARSeries.Add(new ChartDataPointViewModel { Label = label, Value = available > 0 ? Math.Round(revenue / available, 0) : 0 });
                chart.ADRSeries.Add(new ChartDataPointViewModel { Label = label, Value = sold > 0 ? Math.Round(revenue / sold, 0) : 0 });
                chart.OccupancySeries.Add(new ChartDataPointViewModel { Label = label, Value = available > 0 ? Math.Round((decimal)sold / available * 100, 1) : 0 });
            }

            // Revenue by source
            chart.RevenueBySource = reservations
                .GroupBy(r => r.ReservationSource?.Name ?? "Neznámý")
                .Select(g => new RevenueBySourceViewModel
                {
                    SourceName = g.Key,
                    Revenue = Math.Round(g.Sum(r => r.TotalPrice * (r.Currency?.Rate ?? 1m)), 0),
                    ReservationCount = g.Count()
                })
                .OrderByDescending(x => x.Revenue)
                .ToList();

            // Revenue by room type
            chart.RevenueByRoomType = reservations
                .GroupBy(r => r.Room?.RoomType?.Name ?? "Neznámý")
                .Select(g => new RevenueByRoomTypeViewModel
                {
                    RoomTypeName = g.Key,
                    Revenue = Math.Round(g.Sum(r => r.TotalPrice * (r.Currency?.Rate ?? 1m)), 0),
                    RoomNightsSold = g.Sum(r => (int)(r.CheckOut.Date - r.CheckIn.Date).TotalDays)
                })
                .OrderByDescending(x => x.Revenue)
                .ToList();

            return chart;
        }

        private static List<(DateTime Start, DateTime End, string Label)> GeneratePeriods(
            DateTime startDate, DateTime endDate, string granularity)
        {
            var periods = new List<(DateTime, DateTime, string)>();
            var czechMonths = new[] { "", "Leden", "Únor", "Březen", "Duben", "Květen", "Červen",
                "Červenec", "Srpen", "Září", "Říjen", "Listopad", "Prosinec" };

            if (granularity == "yearly")
            {
                for (var year = startDate.Year; year <= endDate.Year; year++)
                {
                    var pStart = new DateTime(year, 1, 1);
                    var pEnd = new DateTime(year + 1, 1, 1);
                    if (pStart < startDate) pStart = startDate;
                    if (pEnd > endDate) pEnd = endDate;
                    periods.Add((pStart, pEnd, year.ToString()));
                }
            }
            else if (granularity == "daily")
            {
                for (var d = startDate.Date; d < endDate.Date; d = d.AddDays(1))
                {
                    periods.Add((d, d.AddDays(1), d.ToString("dd.MM.")));
                }
            }
            else // monthly
            {
                var current = new DateTime(startDate.Year, startDate.Month, 1);
                while (current < endDate)
                {
                    var pStart = current < startDate ? startDate : current;
                    var nextMonth = current.AddMonths(1);
                    var pEnd = nextMonth > endDate ? endDate : nextMonth;
                    var label = $"{czechMonths[current.Month]} {current.Year}";
                    periods.Add((pStart, pEnd, label));
                    current = nextMonth;
                }
            }

            return periods;
        }
    }
}
