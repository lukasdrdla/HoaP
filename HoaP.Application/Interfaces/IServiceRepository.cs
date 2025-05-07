using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels;

namespace HoaP.Application.Interfaces
{
    public interface IServiceRepository
    {
        Task<List<ServiceViewModel>> GetAllAsync();
        Task<ServiceViewModel> GetByIdAsync(int id);
        Task CreateAsync(ServiceViewModel reservationService);
        Task UpdateAsync(ServiceViewModel reservationService);
        Task DeleteAsync(int id);

    }
}
