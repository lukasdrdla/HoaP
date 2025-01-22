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
    public class RoomTypeRepository : IRoomTypeRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public RoomTypeRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<RoomTypeViewModel>> GetRoomTypesAsync()
        {
            var roomTypes = await _context.RoomTypes.ToListAsync();
            return _mapper.Map<List<RoomTypeViewModel>>(roomTypes);
        }
    }
}
