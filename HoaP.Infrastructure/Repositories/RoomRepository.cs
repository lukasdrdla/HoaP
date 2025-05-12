using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Room;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public RoomRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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

        public async Task CreateRoomAsync(RoomFormViewModel room)
        {
            bool roomNumberExists = await _context.Rooms
                .AnyAsync(r => r.RoomNumber == room.RoomNumber);

            if (roomNumberExists)
            {
                throw new Exception("Pokoj s tímto číslem již existuje.");
            }
            var entity = _mapper.Map<Room>(room);

            entity.RoomAmenities = room.Amenities
                .Select(a => new RoomAmenity { AmenityId = a.Id })
                .ToList();



            await _context.Rooms.AddAsync(entity);
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

        public Task<RoomViewModel> GetAvailableRoomsAsync(DateTime checkIn, DateTime checkOut, int adults, int children)
        {
            throw new NotImplementedException();
        }

        public async Task<List<RoomViewModel>> GetAvailableRoomsAsync(DateTime checkIn, DateTime checkOut)
        {
            var allRooms = await _context.Rooms
                .ToListAsync();

            var overlappingReservations = await _context.Reservations
                .Where(r => (r.CheckIn < checkOut && r.CheckOut > checkIn))
                .ToListAsync();

            var rooms = allRooms.Where(r => !overlappingReservations.Any(or => or.RoomId == r.Id))
                .ToList();

            return _mapper.Map<List<RoomViewModel>>(rooms);

        }

        public async Task<DetailRoomViewModel> GetRoomByIdAsync(int id)
        {
            var room = await _context.Rooms
                .Include(r => r.RoomType)
                .Include(r => r.RoomStatus)
                .Include(r => r.Currency)
                .Include(r => r.RoomAmenities)
                    .ThenInclude(ra => ra.Amenity)
                .FirstOrDefaultAsync(r => r.Id == id);

            return _mapper.Map<DetailRoomViewModel>(room);
        }


        public async Task<List<RoomViewModel>> GetRooomsAsync()
        {
            var rooms = await _context.Rooms
                .Include(r => r.RoomType)
                .Include(r => r.RoomStatus)
                .Include(r => r.Currency)
                .ToListAsync();
            return _mapper.Map<List<RoomViewModel>>(rooms);
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

        public async Task UpdateRoomAsync(RoomFormViewModel room)
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

            existingRoom.RoomAmenities = room.Amenities.Select(a => new RoomAmenity
            {
                RoomId = existingRoom.Id,
                AmenityId = a.Id
            }).ToList();

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
