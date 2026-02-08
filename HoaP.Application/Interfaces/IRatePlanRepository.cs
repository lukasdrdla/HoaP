using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IRatePlanRepository
    {
        Task<List<RatePlan>> GetRatePlansAsync();
        Task<RatePlan?> GetRatePlanByIdAsync(int id);
        Task CreateRatePlanAsync(RatePlan ratePlan);
        Task UpdateRatePlanAsync(RatePlan ratePlan);
        Task DeleteRatePlanAsync(int id);
        Task<List<RatePlan>> GetActiveRatePlansForDateRangeAsync(
            DateTime startDate, DateTime endDate, int? roomTypeId = null, int? roomId = null);
    }
}
