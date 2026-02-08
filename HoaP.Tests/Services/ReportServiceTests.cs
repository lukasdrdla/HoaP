using HoaP.Application.Interfaces;
using HoaP.Application.Services;
using HoaP.Application.ViewModels.Report;
using HoaP.Domain.Entities;
using Moq;

namespace HoaP.Tests.Services
{
    public class ReportServiceTests
    {
        private readonly Mock<IReportRepository> _repoMock;
        private readonly ReportService _service;

        public ReportServiceTests()
        {
            _repoMock = new Mock<IReportRepository>();
            _service = new ReportService(_repoMock.Object);
        }

        [Fact]
        public async Task GetKpi_NoReservations_ReturnsZeroMetrics()
        {
            _repoMock.Setup(r => r.GetTotalRoomCountAsync()).ReturnsAsync(4);
            _repoMock.Setup(r => r.GetReservationsForReportAsync(
                It.IsAny<DateTime>(), It.IsAny<DateTime>()))
                .ReturnsAsync(new List<Reservation>());

            var filter = new ReportFilterViewModel
            {
                StartDate = new DateTime(2025, 1, 1),
                EndDate = new DateTime(2025, 1, 31)
            };

            var kpi = await _service.GetKpiAsync(filter);

            Assert.Equal(0m, kpi.TotalRevenue);
            Assert.Equal(0m, kpi.RevPAR);
            Assert.Equal(0m, kpi.ADR);
            Assert.Equal(0m, kpi.OccupancyRate);
            Assert.Equal(0, kpi.TotalRoomNightsSold);
            Assert.Equal(120, kpi.TotalAvailableRoomNights); // 4 rooms * 30 days
        }

        [Fact]
        public async Task GetKpi_WithReservations_CalculatesCorrectly()
        {
            _repoMock.Setup(r => r.GetTotalRoomCountAsync()).ReturnsAsync(2);

            var reservations = new List<Reservation>
            {
                new Reservation
                {
                    Id = 1, RoomId = 1, CheckIn = new DateTime(2025, 1, 1),
                    CheckOut = new DateTime(2025, 1, 11), TotalPrice = 20000,
                    IsCanceled = false,
                    Currency = new Currency { Id = 3, Code = "CZK", Rate = 1m }
                },
                new Reservation
                {
                    Id = 2, RoomId = 2, CheckIn = new DateTime(2025, 1, 5),
                    CheckOut = new DateTime(2025, 1, 10), TotalPrice = 10000,
                    IsCanceled = false,
                    Currency = new Currency { Id = 3, Code = "CZK", Rate = 1m }
                }
            };

            _repoMock.Setup(r => r.GetReservationsForReportAsync(
                It.IsAny<DateTime>(), It.IsAny<DateTime>()))
                .ReturnsAsync(reservations);

            var filter = new ReportFilterViewModel
            {
                StartDate = new DateTime(2025, 1, 1),
                EndDate = new DateTime(2025, 1, 31)
            };

            var kpi = await _service.GetKpiAsync(filter);

            Assert.True(kpi.TotalRevenue > 0);
            Assert.True(kpi.RevPAR > 0);
            Assert.True(kpi.ADR > 0);
            Assert.True(kpi.OccupancyRate > 0);
            Assert.Equal(15, kpi.TotalRoomNightsSold); // 10 + 5
        }

        [Fact]
        public async Task GetKpi_CurrencyConversion_ConvertsToCZK()
        {
            _repoMock.Setup(r => r.GetTotalRoomCountAsync()).ReturnsAsync(1);

            var reservations = new List<Reservation>
            {
                new Reservation
                {
                    Id = 1, RoomId = 1, CheckIn = new DateTime(2025, 1, 1),
                    CheckOut = new DateTime(2025, 1, 2), TotalPrice = 100,
                    IsCanceled = false,
                    Currency = new Currency { Id = 2, Code = "EUR", Rate = 25m }
                }
            };

            _repoMock.Setup(r => r.GetReservationsForReportAsync(
                It.IsAny<DateTime>(), It.IsAny<DateTime>()))
                .ReturnsAsync(reservations);

            var filter = new ReportFilterViewModel
            {
                StartDate = new DateTime(2025, 1, 1),
                EndDate = new DateTime(2025, 1, 2)
            };

            var kpi = await _service.GetKpiAsync(filter);

            Assert.Equal(2500m, kpi.TotalRevenue); // 100 EUR * 25 CZK/EUR
        }
    }
}
