using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels.InsuranceCompany;

namespace HoaP.Application.Interfaces
{
    public interface IInsuranceCompanyRepository
    {
        Task<List<InsuranceCompanyViewModel>> GetInsuranceCompaniesAsync();
        Task<InsuranceCompanyViewModel> GetInsuranceCompanyByIdAsync(int id);
        Task CreateInsuranceCompanyAsync(InsuranceCompanyViewModel model);
        Task UpdateInsuranceCompanyAsync(InsuranceCompanyViewModel model);
        Task DeleteInsuranceCompanyAsync(int id);


    }
}
