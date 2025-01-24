using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels.Currency;

namespace HoaP.Application.Interfaces
{
    public interface ICurrencyRepository
    {
        Task<List<CurrencyViewModel>> GetCurrenciesAsync();
        Task<CurrencyViewModel> GetCurrencyByIdAsync(int id);
        Task CreateCurrencyAsync(CurrencyViewModel model);
        Task UpdateCurrencyAsync(CurrencyViewModel model);
        Task DeleteCurrencyAsync(int id);
    }
}
