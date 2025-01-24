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
    public class RoomTypeRepository : IRoomTypeRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public RoomTypeRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateRoomTypeAsync(RoomTypeViewModel model)
        {
            await _context.RoomTypes.AddAsync(_mapper.Map<RoomType>(model));
            await _context.SaveChangesAsync();

        }

        public async Task DeleteRoomTypeAsync(int id)
        {
            var existingRoomType = await _context.RoomTypes.FindAsync(id);
            _context.RoomTypes.Remove(existingRoomType);
            await _context.SaveChangesAsync();
        }

        public async Task<RoomTypeViewModel> GetRoomTypeByIdAsync(int id)
        {
            var roomType = await _context.RoomTypes.FindAsync(id);
            return _mapper.Map<RoomTypeViewModel>(roomType);
        }

        public async Task<List<RoomTypeViewModel>> GetRoomTypesAsync()
        {
            var roomTypes = await _context.RoomTypes.ToListAsync();
            return _mapper.Map<List<RoomTypeViewModel>>(roomTypes);
        }

        public async Task UpdateRoomTypeAsync(RoomTypeViewModel model)
        {
            var existingRoomType = await _context.RoomTypes.FindAsync(model.Id);

            if (existingRoomType != null)
            {
                _mapper.Map(model, existingRoomType);
                _context.RoomTypes.Update(existingRoomType);
                await _context.SaveChangesAsync();
            }
        }
    }
}
