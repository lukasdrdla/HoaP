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
    public class RoomRepository : IRoomRepository
    {
        private readonly ApplicationDbContext _context;

        public RoomRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task EnableRoom(int id)
        {
            var existingRoom = await _context.Rooms.FindAsync(id);
            if (existingRoom != null)
            {
                existingRoom.IsDisable = false;
                existingRoom.RoomStatusId = 1;
                await _context.SaveChangesAsync();
            }
        }

        public async Task CreateRoomAsync(Room room)
        {
            bool roomNumberExists = await _context.Rooms
                .AnyAsync(r => r.RoomNumber == room.RoomNumber);

            if (roomNumberExists)
            {
                throw new Exception("Pokoj s tímto číslem již existuje.");
            }

            await _context.Rooms.AddAsync(room);
            await _context.SaveChangesAsync();
        }

        public async Task DisableRoom(int id)
        {
            var existingRoom = await _context.Rooms.FindAsync(id);
            if (existingRoom != null)
            {
                existingRoom.IsDisable = true;
                existingRoom.RoomStatusId = 3;
                await _context.SaveChangesAsync();
            }
        }

        public Task<Room?> GetAvailableRoomsAsync(DateTime checkIn, DateTime checkOut, int adults, int children)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Room>> GetAvailableRoomsAsync(DateTime checkIn, DateTime checkOut)
        {
            var allRooms = await _context.Rooms.ToListAsync();

            var overlappingReservations = await _context.Reservations
                .Where(r => (r.CheckIn < checkOut && r.CheckOut > checkIn))
                .ToListAsync();

            return allRooms.Where(r => !overlappingReservations.Any(or => or.RoomId == r.Id))
                .ToList();
        }

        public async Task<Room?> GetRoomByIdAsync(int id)
        {
            return await _context.Rooms
                .AsNoTracking()
                .Include(r => r.RoomType)
                .Include(r => r.RoomStatus)
                .Include(r => r.Currency)
                .Include(r => r.RoomAmenities)
                    .ThenInclude(ra => ra.Amenity)
                .FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<List<Room>> GetRooomsAsync()
        {
            return await _context.Rooms
                .AsNoTracking()
                .Include(r => r.RoomType)
                .Include(r => r.RoomStatus)
                .Include(r => r.Currency)
                .ToListAsync();
        }

        public async Task<List<DateTime>> GetUnavaibleDatesAsync(int roomId)
        {
            var reservations = await _context.Reservations
                .Where(r => r.RoomId == roomId)
                .Select(r => new { r.CheckIn, r.CheckOut })
                .ToListAsync();

            var unavailableDates = new List<DateTime>();

            foreach (var reservation in reservations)
            {
                if (reservation.CheckIn != null && reservation.CheckOut != null)
                {
                    var startDate = reservation.CheckIn.Date;
                    var endDate = reservation.CheckOut.Date;

                    for (var date = startDate; date <= endDate; date = date.AddDays(1))
                    {
                        unavailableDates.Add(date);
                    }
                }
            }

            return unavailableDates;
        }

        public async Task UpdateRoomAsync(Room room)
        {
            var existingRoom = await _context.Rooms
                .Include(r => r.RoomAmenities)
                .FirstOrDefaultAsync(r => r.Id == room.Id);

            if (existingRoom == null)
                return;

            bool roomNumberExists = await _context.Rooms
                .AnyAsync(r => r.RoomNumber == room.RoomNumber && r.Id != room.Id);

            if (roomNumberExists)
            {
                throw new Exception("Pokoj s tímto číslem již existuje.");
            }

            existingRoom.RoomNumber = room.RoomNumber;
            existingRoom.RoomTypeId = room.RoomTypeId;
            existingRoom.RoomStatusId = room.RoomStatusId;
            existingRoom.Description = room.Description;
            existingRoom.Price = room.Price;
            existingRoom.Image = room.Image;
            existingRoom.MaxAdults = room.MaxAdults;
            existingRoom.MaxChildren = room.MaxChildren;
            existingRoom.CurrencyId = room.CurrencyId;
            existingRoom.UpdatedAt = DateTime.Now;

            _context.RoomAmenities.RemoveRange(existingRoom.RoomAmenities);
            existingRoom.RoomAmenities = room.RoomAmenities;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteRoomAsync(int id)
        {
            var existingRoom = await _context.Rooms.FindAsync(id);
            if (existingRoom != null)
            {
                _context.Rooms.Remove(existingRoom);
                await _context.SaveChangesAsync();
            }
        }
    }
}
