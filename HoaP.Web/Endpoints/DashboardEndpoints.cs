using HoaP.Application.Services;
using HoaP.Application.ViewModels.DashBoard;

namespace HoaP.Web.Endpoints
{
    public static class DashboardEndpoints
    {
        public static void MapDashboardEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("/api/dashboard").RequireAuthorization();

            group.MapGet("/", async (DashBoardService service) =>
            {
                var data = new DashBoardViewModel
                {
                    TotalCustomers = await service.GetTotalCustomers(),
                    TotalReservations = await service.GetTotalReservations(),
                    TotalRooms = await service.GetTotalRooms(),
                    RevenueFromLastMonth = await service.GetRevenueFromLastMonth()
                };

                return Results.Ok(data);
            });
        }
    }
}
