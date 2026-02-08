using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IReportRepository
    {
        Task<int> GetTotalRoomCountAsync();
        Task<List<Reservation>> GetReservationsForReportAsync(DateTime startDate, DateTime endDate);
    }
}
