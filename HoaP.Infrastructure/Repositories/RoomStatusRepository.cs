using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Room;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class RoomStatusRepository : IRoomStatusRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public RoomStatusRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateRoomStatusAsync(RoomStatusViewModel model)
        {
            await _context.RoomStatuses.AddAsync(_mapper.Map<RoomStatus>(model));
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRoomStatusAsync(int id)
        {
            var existingRoomStatus = await _context.RoomStatuses.FindAsync(id);
            if (existingRoomStatus != null)
            {
                _context.RoomStatuses.Remove(existingRoomStatus);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<RoomStatusViewModel> GetRoomStatusByIdAsync(int id)
        {
            var roomStatus = await _context.RoomStatuses.FindAsync(id);
            return _mapper.Map<RoomStatusViewModel>(roomStatus);
        }

        public async Task<List<RoomStatusViewModel>> GetRoomStatusesAsync()
        {
            var roomStatuses = await _context.RoomStatuses.ToListAsync();
            return _mapper.Map<List<RoomStatusViewModel>>(roomStatuses);
        }

        public async Task UpdateRoomStatusAsync(RoomStatusViewModel model)
        {
            var existingRoomStatus = await _context.RoomStatuses.FindAsync(model.Id);
            if (existingRoomStatus != null)
            {
                _mapper.Map(model, existingRoomStatus);
                _context.RoomStatuses.Update(existingRoomStatus);
                await _context.SaveChangesAsync();
            }
        }
    }
}
