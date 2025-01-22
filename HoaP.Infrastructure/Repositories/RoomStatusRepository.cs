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
    public class RoomStatusRepository : IRoomStatusRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public RoomStatusRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<RoomStatusViewModel>> GetRoomStatusesAsync()
        {
            var roomStatuses = await _context.RoomStatuses.ToListAsync();
            return _mapper.Map<List<RoomStatusViewModel>>(roomStatuses);
        }
    }
}
