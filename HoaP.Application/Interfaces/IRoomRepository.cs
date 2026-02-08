using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IRoomRepository
    {
        Task<List<Room>> GetRooomsAsync();
        Task<Room?> GetRoomByIdAsync(int id);
        Task CreateRoomAsync(Room room);
        Task UpdateRoomAsync(Room room);
        Task DeleteRoomAsync(int id);
        Task DisableRoom(int id);
        Task EnableRoom(int id);

        Task<Room?> GetAvailableRoomsAsync(DateTime checkIn, DateTime checkOut, int adults, int children);
        Task<List<DateTime>> GetUnavaibleDatesAsync(int roomId);
        Task<List<Room>> GetAvailableRoomsAsync(DateTime checkIn, DateTime checkOut);
    }
}
