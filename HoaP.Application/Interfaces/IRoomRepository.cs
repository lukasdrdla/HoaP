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
        Task CreateRoomAsync(CreateRoomViewModel room);
        Task UpdateRoomAsync(UpdateRoomViewModel room);
        Task DeleteRoomAsync(int id);
    }
}
