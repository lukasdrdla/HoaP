using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Payment;

namespace HoaP.Application.Services
{
    public class PaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<List<PaymentViewModel>> GetPaymentsAsync()
        {
            return await _paymentRepository.GetPaymentsAsync();
        }

        public async Task<DetailPaymentViewModel> GetPaymentByIdAsync(Guid id)
        {
            return await _paymentRepository.GetPaymentByIdAsync(id);
        }

        public async Task CreatePaymentAsync(PaymentFormViewModel payment)
        {
            await _paymentRepository.CreatePaymentAsync(payment);
        }

        public async Task UpdatePaymentAsync(PaymentFormViewModel payment)
        {
            await _paymentRepository.UpdatePaymentAsync(payment);
        }

        public async Task DeletePaymentAsync(Guid id)
        {
            await _paymentRepository.DeletePaymentAsync(id);
        }

        public async Task<List<PaymentViewModel>> GetPaymentsByReservationIdAsync(int reservationId)
        {
            return await _paymentRepository.GetPaymentsByReservationIdAsync(reservationId);
        }

    }
}
