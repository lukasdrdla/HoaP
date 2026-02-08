using HoaP.Application.Services;
using HoaP.Application.ViewModels.Room;

namespace HoaP.Web.Endpoints
{
    public static class RoomEndpoints
    {
        public static void MapRoomEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("/api/rooms").RequireAuthorization();

            group.MapGet("/", async (RoomService service) =>
            {
                var rooms = await service.GetRoomsAsync();
                return Results.Ok(rooms);
            });

            group.MapGet("/{id:int}", async (int id, RoomService service) =>
            {
                var room = await service.GetRoomByIdAsync(id);
                if (room is null)
                    return Results.NotFound();

                return Results.Ok(room);
            });

            group.MapPost("/", async (RoomFormViewModel model, RoomService service) =>
            {
                try
                {
                    await service.CreateRoomAsync(model);
                    return Results.Created();
                }
                catch (InvalidOperationException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            });

            group.MapPut("/{id:int}", async (int id, RoomFormViewModel model, RoomService service) =>
            {
                try
                {
                    model.Id = id;
                    await service.UpdateRoomAsync(model);
                    return Results.NoContent();
                }
                catch (InvalidOperationException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            });

            group.MapDelete("/{id:int}", async (int id, RoomService service) =>
            {
                try
                {
                    await service.DeleteRoomAsync(id);
                    return Results.NoContent();
                }
                catch (InvalidOperationException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            });

            group.MapGet("/available", async (DateTime checkIn, DateTime checkOut, RoomService service) =>
            {
                try
                {
                    var rooms = await service.GetAvailableRoomsAsync(checkIn, checkOut);
                    return Results.Ok(rooms);
                }
                catch (InvalidOperationException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            });
        }
    }
}
