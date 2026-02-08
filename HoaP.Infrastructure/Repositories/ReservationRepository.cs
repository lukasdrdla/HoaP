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
    public class ReservationRepository : IReservationRepository
    {
        private readonly ApplicationDbContext _context;

        public ReservationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateReservationAsync(Reservation reservation, List<Customer> guestsToUpdate)
        {
            foreach (var guest in guestsToUpdate)
            {
                var existingCustomer = await _context.Customers.FirstOrDefaultAsync(c => c.Id == guest.Id);
                if (existingCustomer != null)
                {
                    existingCustomer.FirstName = guest.FirstName;
                    existingCustomer.LastName = guest.LastName;
                    existingCustomer.Email = guest.Email;
                    existingCustomer.Phone = guest.Phone;
                    existingCustomer.DocumentNumber = guest.DocumentNumber;
                    existingCustomer.PersonalIdentificationNumber = guest.PersonalIdentificationNumber;
                    existingCustomer.Nationality = guest.Nationality;
                    existingCustomer.Address = guest.Address;
                    existingCustomer.City = guest.City;
                    existingCustomer.PostalCode = guest.PostalCode;
                    existingCustomer.Country = guest.Country;
                    existingCustomer.PlaceOfBirth = guest.PlaceOfBirth;
                    existingCustomer.DateOfBirth = guest.DateOfBirth;
                    existingCustomer.DateOfIssue = guest.DateOfIssue;
                    existingCustomer.DateOfExpiry = guest.DateOfExpiry;
                    _context.Customers.Update(existingCustomer);
                }
            }

            await _context.Reservations.AddAsync(reservation);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateReservationAsync(Reservation reservation)
        {
            var existingReservation = await _context.Reservations
                .Include(r => r.ServiceReservations)
                .Include(r => r.ReservationCustomers)
                .FirstOrDefaultAsync(r => r.Id == reservation.Id);

            if (existingReservation != null)
            {
                _context.Entry(existingReservation).CurrentValues.SetValues(reservation);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateReservationStatusAsync(int id, int statusId, bool? isCanceled = null)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation != null)
            {
                reservation.ReservationStatusId = statusId;
                if (isCanceled.HasValue)
                {
                    reservation.IsCanceled = isCanceled.Value;
                }
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteReservationAsync(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation != null)
            {
                _context.Reservations.Remove(reservation);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> IsRoomAvailableAsync(int roomId, DateTime checkIn, DateTime checkOut, int? excludeReservationId = null)
        {
            var query = _context.Reservations
                .Where(r => r.RoomId == roomId
                    && r.CheckIn < checkOut
                    && r.CheckOut > checkIn
                    && r.ReservationStatusId != 2
                    && r.ReservationStatusId != 5
                    && r.ReservationStatusId != 6);

            if (excludeReservationId.HasValue)
            {
                query = query.Where(r => r.Id != excludeReservationId.Value);
            }

            return !await query.AnyAsync();
        }

        public async Task<bool> HasInvoiceAsync(int id)
        {
            return await _context.Reservations
                .AsNoTracking()
                .Where(r => r.Id == id)
                .AnyAsync(r => r.InvoiceId != null);
        }

        public async Task<int?> GetReservationStatusIdAsync(int id)
        {
            return await _context.Reservations
                .AsNoTracking()
                .Where(r => r.Id == id)
                .Select(r => (int?)r.ReservationStatusId)
                .FirstOrDefaultAsync();
        }

        public async Task<Reservation?> GetReservationByIdAsync(int id)
        {
            return await _context.Reservations
                .AsNoTracking()
                .Include(r => r.ReservationStatus)
                .Include(r => r.ServiceReservations)
                    .ThenInclude(sr => sr.Service)
                .Include(r => r.Customer)
                .Include(r => r.Room)
                    .ThenInclude(rt => rt.RoomType)
                .Include(r => r.ReservationCustomers)
                    .ThenInclude(rc => rc.Customer)
                .Include(r => r.MealPlan)
                .Include(r => r.Currency)
                .FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<List<Reservation>> GetReservationsAsync()
        {
            return await _context.Reservations
                .AsNoTracking()
                .Include(r => r.ReservationCustomers)
                    .ThenInclude(rc => rc.Customer)
                .Include(r => r.Room)
                .Include(r => r.ReservationStatus)
                .Include(r => r.Currency)
                .ToListAsync();
        }

        public async Task<List<Reservation>> GetReservationsByCustomerIdAsync(int customerId)
        {
            return await _context.Reservations
                .AsNoTracking()
                .Include(r => r.ReservationStatus)
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .Where(r => r.CustomerId == customerId)
                .ToListAsync();
        }

        public async Task<List<Reservation>> GetReservationsByRoomIdAsync(int roomId)
        {
            return await _context.Reservations
                .AsNoTracking()
                .Include(r => r.Invoice)
                .Include(r => r.Currency)
                .Include(r => r.ReservationStatus)
                .Include(r => r.Room)
                .Include(r => r.MealPlan)
                .Include(r => r.ServiceReservations)
                    .ThenInclude(sr => sr.Service)
                .Include(r => r.ReservationCustomers)
                    .ThenInclude(rc => rc.Customer)
                .Where(r => r.RoomId == roomId)
                .ToListAsync();
        }

        public async Task<List<Reservation>> GetReservationsByDateRangeAsync(DateTime from, DateTime to)
        {
            return await _context.Reservations
                .AsNoTracking()
                .Include(r => r.ReservationCustomers)
                    .ThenInclude(rc => rc.Customer)
                .Include(r => r.Room)
                .Include(r => r.ReservationStatus)
                .Include(r => r.Currency)
                .Where(r => r.CheckIn < to && r.CheckOut > from)
                .ToListAsync();
        }
    }
}
