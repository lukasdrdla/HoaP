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
    public class RoomService
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IMapper _mapper;

        public RoomService(IRoomRepository roomRepository, IMapper mapper)
        {
            _roomRepository = roomRepository;
            _mapper = mapper;
        }

        public async Task<List<RoomViewModel>> GetRoomsAsync()
        {
            var entities = await _roomRepository.GetRooomsAsync();
            return _mapper.Map<List<RoomViewModel>>(entities);
        }

        public async Task<DetailRoomViewModel> GetRoomByIdAsync(int id)
        {
            var entity = await _roomRepository.GetRoomByIdAsync(id);
            return _mapper.Map<DetailRoomViewModel>(entity);
        }

        public async Task CreateRoomAsync(RoomFormViewModel room)
        {
            var entity = _mapper.Map<Room>(room);
            entity.RoomAmenities = room.Amenities
                .Select(a => new RoomAmenity { AmenityId = a.Id })
                .ToList();
            await _roomRepository.CreateRoomAsync(entity);
        }

        public async Task UpdateRoomAsync(RoomFormViewModel room)
        {
            var entity = _mapper.Map<Room>(room);
            entity.RoomAmenities = room.Amenities
                .Select(a => new RoomAmenity { RoomId = room.Id ?? 0, AmenityId = a.Id })
                .ToList();
            await _roomRepository.UpdateRoomAsync(entity);
        }

        public async Task DeleteRoomAsync(int id)
        {
            await _roomRepository.DeleteRoomAsync(id);
        }

        public async Task DisableRoomAsync(int id)
        {
            await _roomRepository.DisableRoom(id);
        }

        public async Task EnableRoomAsync(int id)
        {
            await _roomRepository.EnableRoom(id);
        }

        public async Task<RoomViewModel> GetAvailableRoomsAsync(DateTime checkIn, DateTime checkOut, int adults, int children)
        {
            var entity = await _roomRepository.GetAvailableRoomsAsync(checkIn, checkOut, adults, children);
            return _mapper.Map<RoomViewModel>(entity);
        }

        public async Task<List<DateTime>> GetUnavaibleDatesAsync(int roomId)
        {
            return await _roomRepository.GetUnavaibleDatesAsync(roomId);
        }

        public async Task<List<RoomViewModel>> GetAvailableRoomsAsync(DateTime checkIn, DateTime checkOut)
        {
            var entities = await _roomRepository.GetAvailableRoomsAsync(checkIn, checkOut);
            return _mapper.Map<List<RoomViewModel>>(entities);
        }
    }
}
