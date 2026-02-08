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
    public class RoomStatusService
    {
        private readonly IRoomStatusRepository _roomStatusRepository;
        private readonly IMapper _mapper;

        public RoomStatusService(IRoomStatusRepository roomStatusRepository, IMapper mapper)
        {
            _roomStatusRepository = roomStatusRepository;
            _mapper = mapper;
        }

        public async Task<List<RoomStatusViewModel>> GetRoomStatusesAsync()
        {
            var entities = await _roomStatusRepository.GetRoomStatusesAsync();
            return _mapper.Map<List<RoomStatusViewModel>>(entities);
        }

        public async Task<RoomStatusViewModel> GetRoomStatusByIdAsync(int id)
        {
            var entity = await _roomStatusRepository.GetRoomStatusByIdAsync(id);
            return _mapper.Map<RoomStatusViewModel>(entity);
        }

        public async Task CreateRoomStatusAsync(RoomStatusViewModel model)
        {
            var entity = _mapper.Map<RoomStatus>(model);
            await _roomStatusRepository.CreateRoomStatusAsync(entity);
        }

        public async Task UpdateRoomStatusAsync(RoomStatusViewModel model)
        {
            var entity = _mapper.Map<RoomStatus>(model);
            await _roomStatusRepository.UpdateRoomStatusAsync(entity);
        }

        public async Task DeleteRoomStatusAsync(int id)
        {
            await _roomStatusRepository.DeleteRoomStatusAsync(id);
        }
    }
}
