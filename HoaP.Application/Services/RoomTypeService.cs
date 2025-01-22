using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Room;

namespace HoaP.Application.Services
{
    public class RoomTypeService
    {
        private readonly IRoomTypeRepository _roomTypeRepository;

        public RoomTypeService(IRoomTypeRepository roomTypeRepository)
        {
            _roomTypeRepository = roomTypeRepository;
        }

        public async Task<List<RoomTypeViewModel>> GetRoomTypesAsync()
        {
            return await _roomTypeRepository.GetRoomTypesAsync();
        }
    }
}
