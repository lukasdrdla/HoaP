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

        public async Task CreateAmenityAsync(AmenityViewModel amenity)
        {
            await _context.Amenities.AddAsync(_mapper.Map<Amenity>(amenity));
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAmenityAsync(int id)
        {
            var eixstingAmenity = await _context.Amenities.FindAsync(id);
            if (eixstingAmenity != null)
            {
                _context.Amenities.Remove(eixstingAmenity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<AmenityViewModel>> GetAmenitiesAsync()
        {
            var amenities = await _context.Amenities.ToListAsync();
            return _mapper.Map<List<AmenityViewModel>>(amenities);
        }

        public async Task<List<AmenityViewModel>> GetAmenitiesByRoomIdAsync(int roomId)
        {
            var amenities = await _context.RoomAmenities.Where(ra => ra.RoomId == roomId).Include(ra => ra.Amenity).ToListAsync();
            return _mapper.Map<List<AmenityViewModel>>(amenities);
        }

        public Task<AmenityViewModel> GetAmenityByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAmenityAsync(AmenityViewModel amenity)
        {
            var existingAmenity = await _context.Amenities.FindAsync(amenity.Id);
            if (existingAmenity != null)
            {
                _mapper.Map(amenity, existingAmenity);
                _context.Amenities.Update(existingAmenity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
