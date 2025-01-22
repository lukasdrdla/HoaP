using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Amenity;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class AmenityRepository : IAmenityRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AmenityRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<Amenity> CreateAmenityAsync(Amenity amenity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAmenityAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Amenity>> GetAmenitiesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<AmenityViewModel>> GetAmenitiesByRoomIdAsync(int roomId)
        {
            var amenities = await _context.RoomAmenities.Where(ra => ra.RoomId == roomId).Include(ra => ra.Amenity).ToListAsync();
            return _mapper.Map<List<AmenityViewModel>>(amenities);
        }

        public Task<Amenity> GetAmenityByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Amenity> UpdateAmenityAsync(Amenity amenity)
        {
            throw new NotImplementedException();
        }
    }
}
