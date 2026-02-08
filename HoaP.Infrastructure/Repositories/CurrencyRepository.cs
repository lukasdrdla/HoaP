using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly ApplicationDbContext _context;

        public CurrencyRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateCurrencyAsync(Currency entity)
        {
            await _context.Currencies.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCurrencyAsync(int id)
        {
            var existing = await _context.Currencies.FindAsync(id);
            if (existing != null)
            {
                _context.Currencies.Remove(existing);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Currency>> GetCurrenciesAsync()
        {
            return await _context.Currencies.AsNoTracking().ToListAsync();
        }

        public async Task<Currency?> GetCurrencyByIdAsync(int id)
        {
            return await _context.Currencies.FindAsync(id);
        }

        public async Task UpdateCurrencyAsync(Currency entity)
        {
            _context.Currencies.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
