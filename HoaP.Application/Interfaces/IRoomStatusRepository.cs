using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels.Room;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IRoomStatusRepository
    {
        Task<List<RoomStatusViewModel>> GetRoomStatusesAsync();
        Task<RoomStatusViewModel> GetRoomStatusByIdAsync(int id);
        Task CreateRoomStatusAsync(RoomStatusViewModel model);
        Task UpdateRoomStatusAsync(RoomStatusViewModel model);
        Task DeleteRoomStatusAsync(int id);
    }
}
