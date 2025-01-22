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
    }
}
