using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Payment;
using HoaP.Domain.Entities;

namespace HoaP.Application.Services
{
    public class PaymentService
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IMapper _mapper;

        public PaymentService(IPaymentRepository paymentRepository, IMapper mapper)
        {
            _paymentRepository = paymentRepository;
            _mapper = mapper;
        }

        public async Task<List<PaymentViewModel>> GetPaymentsAsync()
        {
            var entities = await _paymentRepository.GetPaymentsAsync();
            return _mapper.Map<List<PaymentViewModel>>(entities);
        }

        public async Task<DetailPaymentViewModel> GetPaymentByIdAsync(Guid id)
        {
            var entity = await _paymentRepository.GetPaymentByIdAsync(id);
            return _mapper.Map<DetailPaymentViewModel>(entity);
        }

        public async Task CreatePaymentAsync(PaymentFormViewModel payment)
        {
            var entity = _mapper.Map<Payment>(payment);
            await _paymentRepository.CreatePaymentAsync(entity);
        }

        public async Task UpdatePaymentAsync(PaymentFormViewModel payment)
        {
            var entity = _mapper.Map<Payment>(payment);
            await _paymentRepository.UpdatePaymentAsync(entity);
        }

        public async Task DeletePaymentAsync(Guid id)
        {
            await _paymentRepository.DeletePaymentAsync(id);
        }

        public async Task<List<PaymentViewModel>> GetPaymentsByReservationIdAsync(int reservationId)
        {
            var entities = await _paymentRepository.GetPaymentsByReservationIdAsync(reservationId);
            return _mapper.Map<List<PaymentViewModel>>(entities);
        }
    }
}
