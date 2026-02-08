using HoaP.Application.Interfaces;
using HoaP.Application.Services;
using HoaP.Domain.Entities;
using Moq;

namespace HoaP.Tests.Services
{
    public class RatePlanServiceTests
    {
        private readonly Mock<IRatePlanRepository> _repoMock;
        private readonly Mock<AutoMapper.IMapper> _mapperMock;
        private readonly RatePlanService _service;

        public RatePlanServiceTests()
        {
            _repoMock = new Mock<IRatePlanRepository>();
            _mapperMock = new Mock<AutoMapper.IMapper>();
            _service = new RatePlanService(_repoMock.Object, _mapperMock.Object);
        }

        [Fact]
        public async Task CalculatePrice_NoRatePlans_ReturnsBasePrice()
        {
            _repoMock.Setup(r => r.GetActiveRatePlansForDateRangeAsync(
                It.IsAny<DateTime>(), It.IsAny<DateTime>(), It.IsAny<int?>(), It.IsAny<int?>()))
                .ReturnsAsync(new List<RatePlan>());

            var result = await _service.CalculatePriceForStayAsync(
                roomId: 1, roomTypeId: 1,
                checkIn: new DateTime(2025, 6, 1),
                checkOut: new DateTime(2025, 6, 4),
                basePrice: 1000);

            Assert.Equal(3000m, result); // 3 nights * 1000
        }

        [Fact]
        public async Task CalculatePrice_PercentageSurcharge_AppliesCorrectly()
        {
            var plans = new List<RatePlan>
            {
                new RatePlan
                {
                    Id = 1, Name = "Letní přirážka", StartDate = new DateTime(2025, 6, 1),
                    EndDate = new DateTime(2025, 8, 31), PriceModifier = 20, IsPercentage = true,
                    IsActive = true, Priority = 1,
                    Monday = true, Tuesday = true, Wednesday = true, Thursday = true,
                    Friday = true, Saturday = true, Sunday = true
                }
            };

            _repoMock.Setup(r => r.GetActiveRatePlansForDateRangeAsync(
                It.IsAny<DateTime>(), It.IsAny<DateTime>(), It.IsAny<int?>(), It.IsAny<int?>()))
                .ReturnsAsync(plans);

            var result = await _service.CalculatePriceForStayAsync(
                1, 1, new DateTime(2025, 6, 1), new DateTime(2025, 6, 4), 1000);

            Assert.Equal(3600m, result); // 3 nights * 1200 (1000 + 20%)
        }

        [Fact]
        public async Task CalculatePrice_WeekendSurcharge_OnlyAppliesOnWeekends()
        {
            // 2025-06-06 = Friday, 2025-06-07 = Saturday, 2025-06-08 = Sunday, 2025-06-09 = Monday
            var plans = new List<RatePlan>
            {
                new RatePlan
                {
                    Id = 1, Name = "Víkendová přirážka", StartDate = new DateTime(2025, 1, 1),
                    EndDate = new DateTime(2025, 12, 31), PriceModifier = 50, IsPercentage = true,
                    IsActive = true, Priority = 1,
                    Monday = false, Tuesday = false, Wednesday = false, Thursday = false,
                    Friday = false, Saturday = true, Sunday = true
                }
            };

            _repoMock.Setup(r => r.GetActiveRatePlansForDateRangeAsync(
                It.IsAny<DateTime>(), It.IsAny<DateTime>(), It.IsAny<int?>(), It.IsAny<int?>()))
                .ReturnsAsync(plans);

            var result = await _service.CalculatePriceForStayAsync(
                1, 1, new DateTime(2025, 6, 6), new DateTime(2025, 6, 9), 1000);

            // Fri: 1000 (no plan), Sat: 1500 (+50%), Sun: 1500 (+50%)
            Assert.Equal(4000m, result);
        }

        [Fact]
        public async Task CalculatePrice_FixedDiscount_AppliesCorrectly()
        {
            var plans = new List<RatePlan>
            {
                new RatePlan
                {
                    Id = 1, Name = "Sleva 200 Kč", StartDate = new DateTime(2025, 1, 1),
                    EndDate = new DateTime(2025, 12, 31), PriceModifier = -200, IsPercentage = false,
                    IsActive = true, Priority = 1,
                    Monday = true, Tuesday = true, Wednesday = true, Thursday = true,
                    Friday = true, Saturday = true, Sunday = true
                }
            };

            _repoMock.Setup(r => r.GetActiveRatePlansForDateRangeAsync(
                It.IsAny<DateTime>(), It.IsAny<DateTime>(), It.IsAny<int?>(), It.IsAny<int?>()))
                .ReturnsAsync(plans);

            var result = await _service.CalculatePriceForStayAsync(
                1, 1, new DateTime(2025, 3, 1), new DateTime(2025, 3, 3), 1000);

            Assert.Equal(1600m, result); // 2 nights * 800 (1000 - 200)
        }

        [Fact]
        public async Task CalculatePrice_MinNightsNotMet_FallsBackToBasePrice()
        {
            var plans = new List<RatePlan>
            {
                new RatePlan
                {
                    Id = 1, Name = "Sleva za 7+ nocí", StartDate = new DateTime(2025, 1, 1),
                    EndDate = new DateTime(2025, 12, 31), PriceModifier = -10, IsPercentage = true,
                    MinNights = 7, IsActive = true, Priority = 1,
                    Monday = true, Tuesday = true, Wednesday = true, Thursday = true,
                    Friday = true, Saturday = true, Sunday = true
                }
            };

            _repoMock.Setup(r => r.GetActiveRatePlansForDateRangeAsync(
                It.IsAny<DateTime>(), It.IsAny<DateTime>(), It.IsAny<int?>(), It.IsAny<int?>()))
                .ReturnsAsync(plans);

            // 3 nights - less than 7
            var result = await _service.CalculatePriceForStayAsync(
                1, 1, new DateTime(2025, 3, 1), new DateTime(2025, 3, 4), 1000);

            Assert.Equal(3000m, result); // no discount, base price
        }

        [Fact]
        public async Task CalculatePrice_ZeroNights_ReturnsZero()
        {
            var result = await _service.CalculatePriceForStayAsync(
                1, 1, new DateTime(2025, 3, 1), new DateTime(2025, 3, 1), 1000);

            Assert.Equal(0m, result);
        }
    }
}
