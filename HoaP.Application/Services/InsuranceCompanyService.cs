using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.InsuranceCompany;

namespace HoaP.Application.Services
{
    public class InsuranceCompanyService
    {
        private readonly IInsuranceCompanyRepository _insuranceCompanyRepository;

        public InsuranceCompanyService(IInsuranceCompanyRepository insuranceCompanyRepository)
        {
            _insuranceCompanyRepository = insuranceCompanyRepository;
        }

        public async Task<List<InsuranceCompanyViewModel>> GetInsuranceCompaniesAsync()
        {
            return await _insuranceCompanyRepository.GetInsuranceCompaniesAsync();
        }
    }
}
