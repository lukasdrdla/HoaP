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
    public class PaymentMethodService
    {
        private readonly IPaymentMethodRepository _paymentMethodRepository;
        private readonly IMapper _mapper;

        public PaymentMethodService(IPaymentMethodRepository paymentMethodRepository, IMapper mapper)
        {
            _paymentMethodRepository = paymentMethodRepository;
            _mapper = mapper;
        }

        public async Task<List<PaymentMethodViewModel>> GetPaymentMethodsAsync()
        {
            var entities = await _paymentMethodRepository.GetAllPaymentMethodsAsync();
            return _mapper.Map<List<PaymentMethodViewModel>>(entities);
        }

        public async Task<PaymentMethodViewModel> GetPaymentMethodByIdAsync(int id)
        {
            var entity = await _paymentMethodRepository.GetPaymentMethodByIdAsync(id);
            return _mapper.Map<PaymentMethodViewModel>(entity);
        }

        public async Task CreatePaymentMethodAsync(PaymentMethodViewModel model)
        {
            var entity = _mapper.Map<PaymentMethod>(model);
            await _paymentMethodRepository.CreatePaymentMethodAsync(entity);
        }

        public async Task UpdatePaymentMethodAsync(PaymentMethodViewModel model)
        {
            var entity = _mapper.Map<PaymentMethod>(model);
            await _paymentMethodRepository.UpdatePaymentMethodAsync(entity);
        }

        public async Task DeletePaymentMethodAsync(int id)
        {
            await _paymentMethodRepository.DeletePaymentMethodAsync(id);
        }
    }
}
