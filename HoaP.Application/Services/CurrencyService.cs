using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Currency;

namespace HoaP.Application.Services
{
    public class CurrencyService
    {
        private readonly ICurrencyRepository _currencyRepository;

        public CurrencyService(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task<List<CurrencyViewModel>> GetCurrenciesAsync()
        {
            return await _currencyRepository.GetCurrenciesAsync();
        }

        public async Task<CurrencyViewModel> GetCurrencyByIdAsync(int id)
        {
            return await _currencyRepository.GetCurrencyByIdAsync(id);
        }

        public async Task CreateCurrencyAsync(CurrencyViewModel model)
        {
            await _currencyRepository.CreateCurrencyAsync(model);
        }

        public async Task UpdateCurrencyAsync(CurrencyViewModel model)
        {
            await _currencyRepository.UpdateCurrencyAsync(model);
        }

        public async Task DeleteCurrencyAsync(int id)
        {
            await _currencyRepository.DeleteCurrencyAsync(id);
        }
    }
}
