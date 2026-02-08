using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface ICurrencyRepository
    {
        Task<List<Currency>> GetCurrenciesAsync();
        Task<Currency?> GetCurrencyByIdAsync(int id);
        Task CreateCurrencyAsync(Currency entity);
        Task UpdateCurrencyAsync(Currency entity);
        Task DeleteCurrencyAsync(int id);
    }
}
