using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels.Payment;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IPaymentRepository
    {
        Task<List<PaymentViewModel>> GetPaymentsAsync();
        Task<DetailPaymentViewModel> GetPaymentByIdAsync(Guid id);
        Task CreatePaymentAsync(CreatePaymentViewModel payment);
        Task UpdatePaymentAsync(UpdatePaymentViewModel payment);
        Task DeletePaymentAsync(Guid id);

        Task<List<PaymentViewModel>> GetPaymentsByReservationIdAsync(int reservationId);
    }
}
