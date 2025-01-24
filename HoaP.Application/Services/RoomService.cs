﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Room;

namespace HoaP.Application.Services
{
    public class RoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public async Task<List<RoomViewModel>> GetRoomsAsync()
        {
            return await _roomRepository.GetRooomsAsync();
        }

        public async Task<DetailRoomViewModel> GetRoomByIdAsync(int id)
        {
            return await _roomRepository.GetRoomByIdAsync(id);
        }

        public async Task CreateRoomAsync(RoomFormViewModel room)
        {
            await _roomRepository.CreateRoomAsync(room);
        }

        public async Task UpdateRoomAsync(RoomFormViewModel room)
        {
            await _roomRepository.UpdateRoomAsync(room);
        }

        public async Task DeleteRoomAsync(int id)
        {
            await _roomRepository.DeleteRoomAsync(id);
        }



    }
}
