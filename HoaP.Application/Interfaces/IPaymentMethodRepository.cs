using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IPaymentMethodRepository
    {
        Task<List<PaymentMethod>> GetAllPaymentMethodsAsync();
        Task<PaymentMethod?> GetPaymentMethodByIdAsync(int id);
        Task CreatePaymentMethodAsync(PaymentMethod entity);
        Task UpdatePaymentMethodAsync(PaymentMethod entity);
        Task DeletePaymentMethodAsync(int id);
    }
}
