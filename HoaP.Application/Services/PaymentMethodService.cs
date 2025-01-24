using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Payment;

namespace HoaP.Application.Services
{
    public class PaymentMethodService
    {
        private readonly IPaymentMethodRepository _paymentMethodRepository;

        public PaymentMethodService(IPaymentMethodRepository paymentMethodRepository)
        {
            _paymentMethodRepository = paymentMethodRepository;
        }

        public async Task<List<PaymentMethodViewModel>> GetPaymentMethodsAsync()
        {
            return await _paymentMethodRepository.GetAllPaymentMethodsAsync();
        }

        public async Task<PaymentMethodViewModel> GetPaymentMethodByIdAsync(int id)
        {
            return await _paymentMethodRepository.GetPaymentMethodByIdAsync(id);
        }

        public async Task CreatePaymentMethodAsync(PaymentMethodViewModel model)
        {
            await _paymentMethodRepository.CreatePaymentMethodAsync(model);
        }

        public async Task UpdatePaymentMethodAsync(PaymentMethodViewModel model)
        {
            await _paymentMethodRepository.UpdatePaymentMethodAsync(model);
        }

        public async Task DeletePaymentMethodAsync(int id)
        {
            await _paymentMethodRepository.DeletePaymentMethodAsync(id);
        }
    }
}
