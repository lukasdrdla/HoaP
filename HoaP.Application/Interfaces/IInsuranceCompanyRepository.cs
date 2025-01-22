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

    }
}
