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

        public RoomStatusService(IRoomStatusRepository roomStatusRepository)
        {
            _roomStatusRepository = roomStatusRepository;
        }

        public async Task<List<RoomStatusViewModel>> GetRoomStatusesAsync()
        {
            return await _roomStatusRepository.GetRoomStatusesAsync();
        }

        public async Task<RoomStatusViewModel> GetRoomStatusByIdAsync(int id)
        {
            return await _roomStatusRepository.GetRoomStatusByIdAsync(id);
        }

        public async Task CreateRoomStatusAsync(RoomStatusViewModel model)
        {
            await _roomStatusRepository.CreateRoomStatusAsync(model);
        }

        public async Task UpdateRoomStatusAsync(RoomStatusViewModel model)
        {
            await _roomStatusRepository.UpdateRoomStatusAsync(model);
        }

        public async Task DeleteRoomStatusAsync(int id)
        {
            await _roomStatusRepository.DeleteRoomStatusAsync(id);
        }

    }
}
