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
    }
}
