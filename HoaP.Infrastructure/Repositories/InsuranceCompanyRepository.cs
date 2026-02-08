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
    public class InsuranceCompanyRepository : IInsuranceCompanyRepository
    {
        private readonly ApplicationDbContext _context;

        public InsuranceCompanyRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateInsuranceCompanyAsync(InsuranceCompany entity)
        {
            await _context.InsuranceCompanies.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteInsuranceCompanyAsync(int id)
        {
            var existing = await _context.InsuranceCompanies.FindAsync(id);
            if (existing != null)
            {
                _context.InsuranceCompanies.Remove(existing);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<InsuranceCompany>> GetInsuranceCompaniesAsync()
        {
            return await _context.InsuranceCompanies.AsNoTracking().ToListAsync();
        }

        public async Task<InsuranceCompany?> GetInsuranceCompanyByIdAsync(int id)
        {
            return await _context.InsuranceCompanies.FindAsync(id);
        }

        public async Task UpdateInsuranceCompanyAsync(InsuranceCompany entity)
        {
            _context.InsuranceCompanies.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
