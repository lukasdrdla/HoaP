using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IRoomStatusRepository
    {
        Task<List<RoomStatus>> GetRoomStatusesAsync();
        Task<RoomStatus?> GetRoomStatusByIdAsync(int id);
        Task CreateRoomStatusAsync(RoomStatus entity);
        Task UpdateRoomStatusAsync(RoomStatus entity);
        Task DeleteRoomStatusAsync(int id);
    }
}
