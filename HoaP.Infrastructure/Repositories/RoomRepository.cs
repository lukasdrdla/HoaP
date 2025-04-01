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
            await _context.Rooms.AddAsync(_mapper.Map<Room>(room));
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
            {
                return;
            }

            existingRoom.RoomNumber = room.RoomNumber;
            existingRoom.Price = room.Price;
            existingRoom.MaxAdults = room.MaxAdults;
            existingRoom.MaxChildren = room.MaxChildren;
            existingRoom.RoomStatusId = room.RoomStatusId;
            existingRoom.RoomTypeId = room.RoomTypeId;
            existingRoom.Description = room.Description;
            existingRoom.Image = room.Image;
            existingRoom.UpdatedAt = DateTime.Now;

            existingRoom.RoomAmenities = room.Amenities.Select(a => new RoomAmenity
            {
                AmenityId = a.Id
            }).ToList();


            _context.Rooms.Update(existingRoom);
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
