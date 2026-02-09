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
                return room is null ? Results.NotFound() : Results.Ok(room);
            });

            group.MapPost("/", async (RoomFormViewModel model, RoomService service) =>
            {
                await service.CreateRoomAsync(model);
                return Results.Created();
            });

            group.MapPut("/{id:int}", async (int id, RoomFormViewModel model, RoomService service) =>
            {
                model.Id = id;
                await service.UpdateRoomAsync(model);
                return Results.NoContent();
            });

            group.MapDelete("/{id:int}", async (int id, RoomService service) =>
            {
                await service.DeleteRoomAsync(id);
                return Results.NoContent();
            });

            group.MapGet("/available", async (DateTime checkIn, DateTime checkOut, RoomService service) =>
            {
                var rooms = await service.GetAvailableRoomsAsync(checkIn, checkOut);
                return Results.Ok(rooms);
            });
        }
    }
}
