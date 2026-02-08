using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Amenity;
using HoaP.Domain.Entities;

namespace HoaP.Application.Services
{
    public class AmenityService
    {
        private readonly IAmenityRepository _amenityRepository;
        private readonly IMapper _mapper;

        public AmenityService(IAmenityRepository amenityRepository, IMapper mapper)
        {
            _amenityRepository = amenityRepository;
            _mapper = mapper;
        }

        public async Task<List<AmenityViewModel>> GetAmenitiesByRoomIdAsync(int roomId)
        {
            var entities = await _amenityRepository.GetAmenitiesByRoomIdAsync(roomId);
            return _mapper.Map<List<AmenityViewModel>>(entities);
        }

        public async Task<List<AmenityViewModel>> GetAmenitiesAsync()
        {
            var entities = await _amenityRepository.GetAmenitiesAsync();
            return _mapper.Map<List<AmenityViewModel>>(entities);
        }

        public async Task<AmenityViewModel> GetAmenityByIdAsync(int id)
        {
            var entity = await _amenityRepository.GetAmenityByIdAsync(id);
            return _mapper.Map<AmenityViewModel>(entity);
        }

        public async Task CreateAmenityAsync(AmenityViewModel amenity)
        {
            var entity = _mapper.Map<Amenity>(amenity);
            await _amenityRepository.CreateAmenityAsync(entity);
        }

        public async Task UpdateAmenityAsync(AmenityViewModel amenity)
        {
            var entity = _mapper.Map<Amenity>(amenity);
            await _amenityRepository.UpdateAmenityAsync(entity);
        }

        public async Task DeleteAmenityAsync(int id)
        {
            await _amenityRepository.DeleteAmenityAsync(id);
        }
    }
}
