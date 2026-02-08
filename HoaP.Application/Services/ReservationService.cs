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

namespace HoaP.Application.Services
{
    public class ReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IMapper _mapper;

        public ReservationService(IReservationRepository reservationRepository, IMapper mapper)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }

        public async Task<List<ReservationViewModel>> GetReservationsByRoomIdAsync(int roomId)
        {
            var entities = await _reservationRepository.GetReservationsByRoomIdAsync(roomId);
            return _mapper.Map<List<ReservationViewModel>>(entities);
        }

        public async Task<List<ReservationViewModel>> GetReservationsByCustomerIdAsync(int customerId)
        {
            var entities = await _reservationRepository.GetReservationsByCustomerIdAsync(customerId);
            return _mapper.Map<List<ReservationViewModel>>(entities);
        }

        public async Task<List<ReservationViewModel>> GetReservationsAsync()
        {
            var entities = await _reservationRepository.GetReservationsAsync();
            return _mapper.Map<List<ReservationViewModel>>(entities);
        }

        public async Task<List<ReservationViewModel>> GetReservationsByDateRangeAsync(DateTime from, DateTime to)
        {
            var entities = await _reservationRepository.GetReservationsByDateRangeAsync(from, to);
            return _mapper.Map<List<ReservationViewModel>>(entities);
        }

        public async Task<DetailReservationViewModel> GetReservationByIdAsync(int id)
        {
            var entity = await _reservationRepository.GetReservationByIdAsync(id);
            var result = _mapper.Map<DetailReservationViewModel>(entity);

            if (entity != null)
            {
                var guests = entity.ReservationCustomers
                    .Where(rc => !rc.IsMainGuest)
                    .Select(rc => rc.Customer)
                    .ToList();
                result.Guests = _mapper.Map<List<CustomerViewModel>>(guests);
            }

            return result;
        }

        public async Task CreateReservationAsync(ReservationFormViewModel reservation)
        {
            var isAvailable = await _reservationRepository.IsRoomAvailableAsync(
                reservation.RoomId, reservation.CheckIn, reservation.CheckOut);

            if (!isAvailable)
            {
                throw new InvalidOperationException("Pokoj je v zadaném termínu již obsazený.");
            }

            var newReservation = _mapper.Map<Reservation>(reservation);

            newReservation.ReservationCustomers.Add(new ReservationCustomer
            {
                CustomerId = reservation.CustomerId,
                IsMainGuest = true
            });

            var guestsToUpdate = new List<Customer>();

            foreach (var guest in reservation.Guests)
            {
                if (guest.Id > 0)
                {
                    var guestEntity = _mapper.Map<Customer>(guest);
                    guestsToUpdate.Add(guestEntity);

                    newReservation.ReservationCustomers.Add(new ReservationCustomer
                    {
                        CustomerId = guest.Id.Value,
                        IsMainGuest = false
                    });
                }
                else
                {
                    var guestEntity = _mapper.Map<Customer>(guest);
                    newReservation.ReservationCustomers.Add(new ReservationCustomer
                    {
                        Customer = guestEntity,
                        IsMainGuest = false
                    });
                }
            }

            foreach (var service in reservation.SelectedServices)
            {
                newReservation.ServiceReservations.Add(new ServiceReservation
                {
                    ServiceId = service.ServiceId,
                    Quantity = service.Quantity,
                    UnitPrice = service.UnitPrice,
                    OriginalUnitPrice = service.OriginalUnitPrice,
                    Note = service.Note
                });
            }

            await _reservationRepository.CreateReservationAsync(newReservation, guestsToUpdate);
        }

        public async Task UpdateReservationAsync(ReservationFormViewModel reservation)
        {
            var isAvailable = await _reservationRepository.IsRoomAvailableAsync(
                reservation.RoomId, reservation.CheckIn, reservation.CheckOut, reservation.Id);

            if (!isAvailable)
            {
                throw new InvalidOperationException("Pokoj je v zadaném termínu již obsazený.");
            }

            var entity = _mapper.Map<Reservation>(reservation);
            await _reservationRepository.UpdateReservationAsync(entity);
        }

        public async Task CancelReservationAsync(int id)
        {
            var statusId = await _reservationRepository.GetReservationStatusIdAsync(id);
            if (statusId == null)
                throw new InvalidOperationException("Rezervace nebyla nalezena.");

            if (statusId == 2)
                throw new InvalidOperationException("Rezervace je již zrušená.");

            if (statusId == 5)
                throw new InvalidOperationException("Nelze zrušit rezervaci po check-outu.");

            await _reservationRepository.UpdateReservationStatusAsync(id, 2, isCanceled: true);
        }

        public async Task CheckInAsync(int id)
        {
            var statusId = await _reservationRepository.GetReservationStatusIdAsync(id);
            if (statusId == null)
                throw new InvalidOperationException("Rezervace nebyla nalezena.");

            if (statusId != 1 && statusId != 3)
                throw new InvalidOperationException("Check-in lze provést pouze u potvrzené nebo čekající rezervace.");

            await _reservationRepository.UpdateReservationStatusAsync(id, 4);
        }

        public async Task CheckOutAsync(int id)
        {
            var statusId = await _reservationRepository.GetReservationStatusIdAsync(id);
            if (statusId == null)
                throw new InvalidOperationException("Rezervace nebyla nalezena.");

            if (statusId != 4)
                throw new InvalidOperationException("Check-out lze provést pouze u ubytovaného hosta.");

            await _reservationRepository.UpdateReservationStatusAsync(id, 5);
        }

        public async Task DeleteReservationAsync(int id)
        {
            var hasInvoice = await _reservationRepository.HasInvoiceAsync(id);
            if (hasInvoice)
            {
                throw new InvalidOperationException("Nelze smazat rezervaci, která je přiřazena k faktuře.");
            }

            await _reservationRepository.DeleteReservationAsync(id);
        }
    }
}
