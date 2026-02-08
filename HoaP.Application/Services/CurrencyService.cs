using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Currency;
using HoaP.Domain.Entities;

namespace HoaP.Application.Services
{
    public class CurrencyService
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly IMapper _mapper;

        public CurrencyService(ICurrencyRepository currencyRepository, IMapper mapper)
        {
            _currencyRepository = currencyRepository;
            _mapper = mapper;
        }

        public async Task<List<CurrencyViewModel>> GetCurrenciesAsync()
        {
            var entities = await _currencyRepository.GetCurrenciesAsync();
            return _mapper.Map<List<CurrencyViewModel>>(entities);
        }

        public async Task<CurrencyViewModel> GetCurrencyByIdAsync(int id)
        {
            var entity = await _currencyRepository.GetCurrencyByIdAsync(id);
            return _mapper.Map<CurrencyViewModel>(entity);
        }

        public async Task CreateCurrencyAsync(CurrencyViewModel model)
        {
            var entity = _mapper.Map<Currency>(model);
            await _currencyRepository.CreateCurrencyAsync(entity);
        }

        public async Task UpdateCurrencyAsync(CurrencyViewModel model)
        {
            var entity = _mapper.Map<Currency>(model);
            await _currencyRepository.UpdateCurrencyAsync(entity);
        }

        public async Task DeleteCurrencyAsync(int id)
        {
            await _currencyRepository.DeleteCurrencyAsync(id);
        }
    }
}
