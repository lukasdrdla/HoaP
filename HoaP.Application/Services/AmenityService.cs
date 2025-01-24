using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Amenity;

namespace HoaP.Application.Services
{
    public class AmenityService
    {
        private readonly IAmenityRepository _amenityRepository;

        public AmenityService(IAmenityRepository amenityRepository)
        {
            _amenityRepository = amenityRepository;
        }

        public async Task<List<AmenityViewModel>> GetAmenitiesByRoomIdAsync(int roomId)
        {
            return await _amenityRepository.GetAmenitiesByRoomIdAsync(roomId);
        }

        public async Task<List<AmenityViewModel>> GetAmenitiesAsync()
        {
            return await _amenityRepository.GetAmenitiesAsync();
        }

        public async Task<AmenityViewModel> GetAmenityByIdAsync(int id)
        {
            return await _amenityRepository.GetAmenityByIdAsync(id);
        }

        public async Task CreateAmenityAsync(AmenityViewModel amenity)
        {
            await _amenityRepository.CreateAmenityAsync(amenity);
        }

        public async Task UpdateAmenityAsync(AmenityViewModel amenity)
        {
            await _amenityRepository.UpdateAmenityAsync(amenity);
        }

        public async Task DeleteAmenityAsync(int id)
        {
            await _amenityRepository.DeleteAmenityAsync(id);
        }
    }
}
