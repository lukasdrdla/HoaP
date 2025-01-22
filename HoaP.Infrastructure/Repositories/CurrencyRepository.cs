using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Currency;
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

        public async Task<List<CurrencyViewModel>> GetCurrenciesAsync()
        {
            var currencies = await _context.Currencies.ToListAsync();
            return _mapper.Map<List<CurrencyViewModel>>(currencies);
        }
    }
}
