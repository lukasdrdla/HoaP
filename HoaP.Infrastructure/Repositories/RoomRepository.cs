using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Room;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public RoomRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task CreateRoomAsync(CreateRoomViewModel room)
        {
            await _context.Rooms.AddAsync(_mapper.Map<Domain.Entities.Room>(room));
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRoomAsync(int id)
        {
            var existingRoom = await _context.Rooms.FindAsync(id);
            if (existingRoom != null)
            {
                _context.Rooms.Remove(existingRoom);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<DetailRoomViewModel> GetRoomByIdAsync(int id)
        {
            var room = await _context.Rooms
                .Include(r => r.RoomType)
                .Include(r => r.RoomStatus)
                .FirstOrDefaultAsync(r => r.Id == id);
            return _mapper.Map<DetailRoomViewModel>(room);
        }

        public async Task<List<RoomViewModel>> GetRooomsAsync()
        {
            var rooms = await _context.Rooms
                .Include(r => r.RoomType)
                .Include(r => r.RoomStatus)
                .ToListAsync();
            return _mapper.Map<List<RoomViewModel>>(rooms);
        }

        public Task UpdateRoomAsync(UpdateRoomViewModel room)
        {
            throw new NotImplementedException();
        }
    }
}
