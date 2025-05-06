using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels;
using HoaP.Application.ViewModels.Customer;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ReservationRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task CreateReservationAsync(ReservationFormViewModel reservation)
        {
            var newReservation = _mapper.Map<Reservation>(reservation);

            // Přidej hlavního zákazníka
            newReservation.ReservationCustomers.Add(new ReservationCustomer
            {
                CustomerId = reservation.CustomerId,
                IsMainGuest = true
            });

            foreach (var guest in reservation.Guests)
            {
                if (guest.Id > 0)
                {
                    // Existující zákazník – použij jen referenci
                    newReservation.ReservationCustomers.Add(new ReservationCustomer
                    {
                        CustomerId = guest.Id.Value,
                        IsMainGuest = false
                    });
                }
                else
                {
                    // Nový zákazník – vytvoř entitu
                    var guestEntity = _mapper.Map<Customer>(guest);
                    _context.Customers.Add(guestEntity);
                    // přidej jako navázanou entitu
                    newReservation.ReservationCustomers.Add(new ReservationCustomer
                    {
                        Customer = guestEntity,
                        IsMainGuest = false
                    });
                }
            }

            await _context.Reservations.AddAsync(newReservation);
            await _context.SaveChangesAsync();
        }


        public async Task CancelReservationAsync(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation != null)
            {
                reservation.IsCanceled = true;
                reservation.ReservationStatusId = 2;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<DetailReservationViewModel> GetReservationByIdAsync(int id)
        {
            var reservation = await _context.Reservations
                .Include(r => r.ReservationStatus)
                .Include(r => r.Customer)
                .Include(r => r.Room)
                    .ThenInclude(rt => rt.RoomType)
                .Include(r => r.ReservationCustomers)
                    .ThenInclude(rc => rc.Customer)
                .Include(r => r.MealPlan)
                .FirstOrDefaultAsync(r => r.Id == id);

            var result = _mapper.Map<DetailReservationViewModel>(reservation);

            var guests = await _context.ReservationCustomers
                .Include(rc => rc.Customer)
                .Where(rc => rc.ReservationId == id && !rc.IsMainGuest)
                .Select(rc => rc.Customer)
                .ToListAsync();

            result.Guests = _mapper.Map<List<CustomerViewModel>>(guests);

            return result;
        }


        public async Task<List<ReservationViewModel>> GetReservationsAsync()
        {
            var reservations = await _context.Reservations
                .Include(r => r.ReservationStatus)
                .Include(r => r.Currency)
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .ToListAsync();
            return _mapper.Map<List<ReservationViewModel>>(reservations);
        }

        public async Task<List<ReservationViewModel>> GetReservationsByCustomerIdAsync(int customerId)
        {
            var reservation = await _context.Reservations
                .Include(r => r.ReservationStatus)
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .Where(r => r.CustomerId == customerId)
                .ToListAsync();
            return _mapper.Map<List<ReservationViewModel>>(reservation);
        }

        public async Task<List<ReservationViewModel>> GetReservationsByRoomIdAsync(int roomId)
        {
            var reservations = await _context.Reservations
                .Include(r=> r.InvoiceReservations)
                .ThenInclude(ir => ir.Invoice)
                .Include(r => r.ReservationStatus)
                .Include(r => r.Customer)
                .Where(r => r.RoomId == roomId)
                .ToListAsync();
            return _mapper.Map<List<ReservationViewModel>>(reservations);

        }

        public async Task UpdateReservationAsync(ReservationFormViewModel reservation)
        {
            var existingReservation = await _context.Reservations.FindAsync(reservation.Id);

            if (existingReservation != null)
            {
                _mapper.Map(reservation, existingReservation);
                _context.Reservations.Update(existingReservation);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteReservationAsync(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation != null)
            {
                var invoice = await _context.Invoices
                    .Include(i => i.InvoiceReservations)
                    .ThenInclude(ir => ir.Reservation)
                    .FirstOrDefaultAsync(i => i.InvoiceReservations.Any(ir => ir.ReservationId == id));

                if (invoice != null)
                {
                    throw new Exception("Can't delete reservation with invoice");
                }

                _context.Reservations.Remove(reservation);
                await _context.SaveChangesAsync();
            }
        }
    }
}
