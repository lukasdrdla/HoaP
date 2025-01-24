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

        public async Task<RoomTypeViewModel> GetRoomTypeByIdAsync(int id)
        {
            return await _roomTypeRepository.GetRoomTypeByIdAsync(id);
        }

        public async Task CreateRoomTypeAsync(RoomTypeViewModel model)
        {
            await _roomTypeRepository.CreateRoomTypeAsync(model);
        }

        public async Task UpdateRoomTypeAsync(RoomTypeViewModel model)
        {
            await _roomTypeRepository.UpdateRoomTypeAsync(model);
        }

        public async Task DeleteRoomTypeAsync(int id)
        {
            await _roomTypeRepository.DeleteRoomTypeAsync(id);
        }

    }
}
