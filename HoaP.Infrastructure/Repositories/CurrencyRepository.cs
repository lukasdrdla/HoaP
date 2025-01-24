using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Currency;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CurrencyRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateCurrencyAsync(CurrencyViewModel model)
        {
            await _context.Currencies.AddAsync(_mapper.Map<Currency>(model));
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCurrencyAsync(int id)
        {
            var existingCurrency = await _context.Currencies.FindAsync(id);
            if (existingCurrency != null)
            {
                _context.Currencies.Remove(existingCurrency);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<CurrencyViewModel>> GetCurrenciesAsync()
        {
            var currencies = await _context.Currencies.ToListAsync();
            return _mapper.Map<List<CurrencyViewModel>>(currencies);
        }

        public async Task<CurrencyViewModel> GetCurrencyByIdAsync(int id)
        {
            var currency = await _context.Currencies.FindAsync(id);
            return _mapper.Map<CurrencyViewModel>(currency);
        }

        public async Task UpdateCurrencyAsync(CurrencyViewModel model)
        {
            var existingCurrency = await _context.Currencies.FindAsync(model.Id);

            if (existingCurrency != null)
            {
                _mapper.Map(model, existingCurrency);
                _context.Currencies.Update(existingCurrency);
                await _context.SaveChangesAsync();
            }
        }
    }
}
