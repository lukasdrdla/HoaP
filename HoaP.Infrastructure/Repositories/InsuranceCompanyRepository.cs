using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.InsuranceCompany;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class InsuranceCompanyRepository : IInsuranceCompanyRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public InsuranceCompanyRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateInsuranceCompanyAsync(InsuranceCompanyViewModel model)
        {
            await _context.InsuranceCompanies.AddAsync(_mapper.Map<InsuranceCompany>(model));
            await _context.SaveChangesAsync();
        }

        public async Task DeleteInsuranceCompanyAsync(int id)
        {
            var existingInsuranceCompany = await _context.InsuranceCompanies.FindAsync(id);

            if (existingInsuranceCompany != null)
            {
                _context.InsuranceCompanies.Remove(existingInsuranceCompany);
                await _context.SaveChangesAsync();
            }

        }

        public async Task<List<InsuranceCompanyViewModel>> GetInsuranceCompaniesAsync()
        {
            var insuranceCompanies = await _context.InsuranceCompanies.ToListAsync();
            return _mapper.Map<List<InsuranceCompanyViewModel>>(insuranceCompanies);
        }

        public async Task<InsuranceCompanyViewModel> GetInsuranceCompanyByIdAsync(int id)
        {
            var insuranceCompany = await _context.InsuranceCompanies.FindAsync(id);

            return _mapper.Map<InsuranceCompanyViewModel>(insuranceCompany);
        }

        public async Task UpdateInsuranceCompanyAsync(InsuranceCompanyViewModel model)
        {
            var existingInsuranceCompany = await _context.InsuranceCompanies.FindAsync(model.Id);

            if (existingInsuranceCompany != null)
            {
                _mapper.Map(model, existingInsuranceCompany);
                _context.Update(existingInsuranceCompany);
                await _context.SaveChangesAsync();
            }
        }
    }
}
