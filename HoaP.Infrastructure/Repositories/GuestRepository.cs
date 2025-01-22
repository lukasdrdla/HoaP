using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class GuestRepository : IGuestRepository
    {
        private readonly ApplicationDbContext _context;

        public GuestRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateGuestAsync(Guest guest)
        {
            await _context.Guests.AddAsync(guest);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteGuestAsync(int id)
        {
            var guest = await _context.Guests.FindAsync(id);
            if (guest != null)
            {
                _context.Guests.Remove(guest);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Guest> GetGuestAsync(int id)
        {
            var guest = await _context.Guests.FindAsync(id);
            if (guest != null)
            {
                return guest;
            }

            return null;
        }

        public async Task<List<Guest>> GetGuestsAsync()
        {
            var guests = await _context.Guests.ToListAsync();
            return guests;
        }

        public async Task UpdateGuestAsync(Guest guest)
        {
            var existingGuest = await _context.Guests.FindAsync(guest.Id);
            if (existingGuest != null)
            {
                existingGuest.FirstName = guest.FirstName;
                existingGuest.LastName = guest.LastName;
                existingGuest.DocumentNumber = guest.DocumentNumber;
                existingGuest.DateOfBirth = guest.DateOfBirth;

                _context.Guests.Update(existingGuest);
                await _context.SaveChangesAsync();

            }
        }
    }
}
