using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.HotelProfile;

namespace HoaP.Application.Services
{
    public class HotelProfileService
    {
        private readonly IHotelProfileRepository _hotelProfileRepository;
        private readonly IMapper _mapper;

        public HotelProfileService(IHotelProfileRepository hotelProfileRepository, IMapper mapper)
        {
            _hotelProfileRepository = hotelProfileRepository;
            _mapper = mapper;
        }

        public async Task<HotelProfileViewModel> GetHotelProfileAsync()
        {
            var entity = await _hotelProfileRepository.GetHotelProfileAsync();
            return entity != null ? _mapper.Map<HotelProfileViewModel>(entity) : new HotelProfileViewModel();
        }

        public async Task SaveHotelProfileAsync(HotelProfileViewModel model)
        {
            var entity = _mapper.Map<Domain.Entities.HotelProfile>(model);
            await _hotelProfileRepository.SaveHotelProfileAsync(entity);
        }
    }
}
