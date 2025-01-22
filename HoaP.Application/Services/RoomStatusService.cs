using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Room;

namespace HoaP.Application.Services
{
    public class RoomStatusService : IRoomStatusRepository
    {
        private readonly IRoomStatusRepository _roomStatusRepository;

        public RoomStatusService(IRoomStatusRepository roomStatusRepository)
        {
            _roomStatusRepository = roomStatusRepository;
        }
        public Task<List<RoomStatusViewModel>> GetRoomStatusesAsync()
        {
            return _roomStatusRepository.GetRoomStatusesAsync();
        }
    }
}
