using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IInsuranceCompanyRepository
    {
        Task<List<InsuranceCompany>> GetInsuranceCompaniesAsync();
        Task<InsuranceCompany?> GetInsuranceCompanyByIdAsync(int id);
        Task CreateInsuranceCompanyAsync(InsuranceCompany entity);
        Task UpdateInsuranceCompanyAsync(InsuranceCompany entity);
        Task DeleteInsuranceCompanyAsync(int id);
    }
}
