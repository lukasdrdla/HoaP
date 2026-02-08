using HoaP.Application.Services;
using HoaP.Application.ViewModels.RatePlan;

namespace HoaP.Web.Endpoints
{
    public static class RatePlanEndpoints
    {
        public static void MapRatePlanEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("/api/rate-plans").RequireAuthorization();

            group.MapGet("/", async (RatePlanService service) =>
            {
                var ratePlans = await service.GetRatePlansAsync();
                return Results.Ok(ratePlans);
            });

            group.MapGet("/{id:int}", async (int id, RatePlanService service) =>
            {
                var ratePlan = await service.GetRatePlanByIdAsync(id);
                return ratePlan is null ? Results.NotFound() : Results.Ok(ratePlan);
            });

            group.MapPost("/", async (RatePlanFormViewModel viewModel, RatePlanService service) =>
            {
                try
                {
                    await service.CreateRatePlanAsync(viewModel);
                    return Results.Created();
                }
                catch (Exception ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            });

            group.MapPut("/{id:int}", async (int id, RatePlanFormViewModel viewModel, RatePlanService service) =>
            {
                try
                {
                    viewModel.Id = id;
                    await service.UpdateRatePlanAsync(viewModel);
                    return Results.Ok();
                }
                catch (Exception ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            });

            group.MapDelete("/{id:int}", async (int id, RatePlanService service) =>
            {
                try
                {
                    await service.DeleteRatePlanAsync(id);
                    return Results.Ok();
                }
                catch (Exception ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            });

            group.MapGet("/calculate", async (int roomId, int roomTypeId, DateTime checkIn, DateTime checkOut, decimal basePrice, RatePlanService service) =>
            {
                try
                {
                    var total = await service.CalculatePriceForStayAsync(roomId, roomTypeId, checkIn, checkOut, basePrice);
                    return Results.Ok(new { totalPrice = total });
                }
                catch (Exception ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            });
        }
    }
}
