using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IRoomTypeRepository
    {
        Task<List<RoomType>> GetRoomTypesAsync();
        Task<RoomType?> GetRoomTypeByIdAsync(int id);
        Task CreateRoomTypeAsync(RoomType entity);
        Task UpdateRoomTypeAsync(RoomType entity);
        Task DeleteRoomTypeAsync(int id);
    }
}
