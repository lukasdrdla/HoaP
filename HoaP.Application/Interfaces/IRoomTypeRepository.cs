using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels.Room;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IRoomTypeRepository
    {
        Task<List<RoomTypeViewModel>> GetRoomTypesAsync();
    }
}
