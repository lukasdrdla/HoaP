using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Room;
using HoaP.Domain.Entities;

namespace HoaP.Application.Services
{
    public class RoomTypeService
    {
        private readonly IRoomTypeRepository _roomTypeRepository;
        private readonly IMapper _mapper;

        public RoomTypeService(IRoomTypeRepository roomTypeRepository, IMapper mapper)
        {
            _roomTypeRepository = roomTypeRepository;
            _mapper = mapper;
        }

        public async Task<List<RoomTypeViewModel>> GetRoomTypesAsync()
        {
            var entities = await _roomTypeRepository.GetRoomTypesAsync();
            return _mapper.Map<List<RoomTypeViewModel>>(entities);
        }

        public async Task<RoomTypeViewModel> GetRoomTypeByIdAsync(int id)
        {
            var entity = await _roomTypeRepository.GetRoomTypeByIdAsync(id);
            return _mapper.Map<RoomTypeViewModel>(entity);
        }

        public async Task CreateRoomTypeAsync(RoomTypeViewModel model)
        {
            var entity = _mapper.Map<RoomType>(model);
            await _roomTypeRepository.CreateRoomTypeAsync(entity);
        }

        public async Task UpdateRoomTypeAsync(RoomTypeViewModel model)
        {
            var entity = _mapper.Map<RoomType>(model);
            await _roomTypeRepository.UpdateRoomTypeAsync(entity);
        }

        public async Task DeleteRoomTypeAsync(int id)
        {
            await _roomTypeRepository.DeleteRoomTypeAsync(id);
        }
    }
}
