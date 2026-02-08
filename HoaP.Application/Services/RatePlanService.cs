using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.RatePlan;
using HoaP.Domain.Entities;

namespace HoaP.Application.Services
{
    public class RatePlanService
    {
        private readonly IRatePlanRepository _ratePlanRepository;
        private readonly IMapper _mapper;

        public RatePlanService(IRatePlanRepository ratePlanRepository, IMapper mapper)
        {
            _ratePlanRepository = ratePlanRepository;
            _mapper = mapper;
        }

        public async Task<List<RatePlanViewModel>> GetRatePlansAsync()
        {
            var ratePlans = await _ratePlanRepository.GetRatePlansAsync();
            return _mapper.Map<List<RatePlanViewModel>>(ratePlans);
        }

        public async Task<RatePlanFormViewModel?> GetRatePlanByIdAsync(int id)
        {
            var ratePlan = await _ratePlanRepository.GetRatePlanByIdAsync(id);
            return ratePlan == null ? null : _mapper.Map<RatePlanFormViewModel>(ratePlan);
        }

        public async Task CreateRatePlanAsync(RatePlanFormViewModel viewModel)
        {
            var ratePlan = _mapper.Map<RatePlan>(viewModel);
            await _ratePlanRepository.CreateRatePlanAsync(ratePlan);
        }

        public async Task UpdateRatePlanAsync(RatePlanFormViewModel viewModel)
        {
            var ratePlan = _mapper.Map<RatePlan>(viewModel);
            await _ratePlanRepository.UpdateRatePlanAsync(ratePlan);
        }

        public async Task DeleteRatePlanAsync(int id)
        {
            await _ratePlanRepository.DeleteRatePlanAsync(id);
        }

        /// <summary>
        /// Vypočítá celkovou cenu pobytu s aplikací rate plans.
        /// Iteruje den po dni a pro každý den najde nejvyšší-priority rate plan.
        /// </summary>
        public async Task<decimal> CalculatePriceForStayAsync(
            int roomId, int roomTypeId, DateTime checkIn, DateTime checkOut, decimal basePrice)
        {
            var totalNights = (int)(checkOut.Date - checkIn.Date).TotalDays;
            if (totalNights <= 0) return 0;

            var ratePlans = await _ratePlanRepository.GetActiveRatePlansForDateRangeAsync(
                checkIn.Date, checkOut.Date.AddDays(-1), roomTypeId, roomId);

            decimal totalPrice = 0;

            for (var date = checkIn.Date; date < checkOut.Date; date = date.AddDays(1))
            {
                var dailyPrice = basePrice;
                var applicablePlan = FindApplicablePlan(ratePlans, date, totalNights);

                if (applicablePlan != null)
                {
                    dailyPrice = ApplyModifier(basePrice, applicablePlan);
                }

                totalPrice += dailyPrice;
            }

            return Math.Round(totalPrice, 2);
        }

        private static RatePlan? FindApplicablePlan(List<RatePlan> ratePlans, DateTime date, int totalNights)
        {
            foreach (var plan in ratePlans) // already sorted by Priority DESC
            {
                if (date.Date < plan.StartDate || date.Date > plan.EndDate)
                    continue;

                if (!IsDayApplicable(plan, date.DayOfWeek))
                    continue;

                if (plan.MinNights.HasValue && totalNights < plan.MinNights.Value)
                    continue;

                if (plan.MaxNights.HasValue && totalNights > plan.MaxNights.Value)
                    continue;

                return plan;
            }

            return null;
        }

        private static bool IsDayApplicable(RatePlan plan, DayOfWeek day)
        {
            return day switch
            {
                DayOfWeek.Monday => plan.Monday,
                DayOfWeek.Tuesday => plan.Tuesday,
                DayOfWeek.Wednesday => plan.Wednesday,
                DayOfWeek.Thursday => plan.Thursday,
                DayOfWeek.Friday => plan.Friday,
                DayOfWeek.Saturday => plan.Saturday,
                DayOfWeek.Sunday => plan.Sunday,
                _ => true
            };
        }

        private static decimal ApplyModifier(decimal basePrice, RatePlan plan)
        {
            if (plan.IsPercentage)
            {
                return basePrice * (1 + plan.PriceModifier / 100m);
            }
            else
            {
                return basePrice + plan.PriceModifier;
            }
        }
    }
}
