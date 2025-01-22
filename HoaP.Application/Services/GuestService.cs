using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Domain.Entities;

namespace HoaP.Application.Services
{
    public class GuestService
    {
        private readonly IGuestRepository _guestRepository;

        public GuestService(IGuestRepository guestRepository)
        {
            _guestRepository = guestRepository;
        }

        public async Task<List<Guest>> GetGuests()
        {
            return await _guestRepository.GetGuestsAsync();
        }

        public async Task<Guest> GetGuestById(int id)
        {
            return await _guestRepository.GetGuestAsync(id);
        }

        public async Task CreateGuest(Guest guest)
        {
            await _guestRepository.CreateGuestAsync(guest);
        }

        public async Task UpdateGuest(Guest guest)
        {
            await _guestRepository.UpdateGuestAsync(guest);
        }

        public async Task DeleteGuest(int id)
        {
            await _guestRepository.DeleteGuestAsync(id);
        }


    }
}
