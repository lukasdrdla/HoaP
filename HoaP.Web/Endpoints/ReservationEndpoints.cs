using HoaP.Application.Services;
using HoaP.Application.ViewModels;

namespace HoaP.Web.Endpoints
{
    public static class ReservationEndpoints
    {
        public static void MapReservationEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("/api/reservations").RequireAuthorization();

            group.MapGet("/", async (ReservationService service) =>
            {
                var reservations = await service.GetReservationsAsync();
                return Results.Ok(reservations);
            });

            group.MapGet("/{id:int}", async (int id, ReservationService service) =>
            {
                var reservation = await service.GetReservationByIdAsync(id);
                return reservation is null ? Results.NotFound() : Results.Ok(reservation);
            });

            group.MapPost("/", async (ReservationFormViewModel model, ReservationService service) =>
            {
                await service.CreateReservationAsync(model);
                return Results.Created();
            });

            group.MapPut("/{id:int}", async (int id, ReservationFormViewModel model, ReservationService service) =>
            {
                model.Id = id;
                await service.UpdateReservationAsync(model);
                return Results.NoContent();
            });

            group.MapDelete("/{id:int}", async (int id, ReservationService service) =>
            {
                await service.DeleteReservationAsync(id);
                return Results.NoContent();
            });

            group.MapPost("/{id:int}/check-in", async (int id, ReservationService service) =>
            {
                await service.CheckInAsync(id);
                return Results.Ok(new { message = "Check-in successful." });
            });

            group.MapPost("/{id:int}/check-out", async (int id, ReservationService service) =>
            {
                await service.CheckOutAsync(id);
                return Results.Ok(new { message = "Check-out successful." });
            });

            group.MapPost("/{id:int}/cancel", async (int id, ReservationService service) =>
            {
                await service.CancelReservationAsync(id);
                return Results.Ok(new { message = "Reservation cancelled." });
            });
        }
    }
}
