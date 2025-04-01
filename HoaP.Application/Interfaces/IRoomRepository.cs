using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels.Room;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IRoomRepository
    {
        Task<List<RoomViewModel>> GetRooomsAsync();
        Task<DetailRoomViewModel> GetRoomByIdAsync(int id);
        Task CreateRoomAsync(RoomFormViewModel room);
        Task UpdateRoomAsync(RoomFormViewModel room);
        Task DeleteRoomAsync(int id);
        Task DisableRoom(int id);
        Task EnableRoom(int id);

        Task<RoomViewModel> GetAvailableRoomsAsync(DateTime checkIn, DateTime checkOut, int adults, int children);
        Task<List<DateTime>> GetUnavaibleDatesAsync(int roomId);
        Task<List<RoomViewModel>> GetAvailableRoomsAsync(DateTime checkIn, DateTime checkOut);
    }
}
