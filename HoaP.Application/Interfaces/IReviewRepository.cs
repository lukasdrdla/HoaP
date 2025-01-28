using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels.Review;

namespace HoaP.Application.Interfaces
{
    public interface IReviewRepository
    {
        Task<List<ReviewViewModel>> GetReviewsAsync();
        Task<ReviewViewModel> GetReviewByIdAsync(int id);
        Task CreateReviewAsync(ReviewViewModel review);
        Task UpdateReviewAsync(ReviewViewModel review);
        Task DeleteReviewAsync(int id);

        Task<List<ReviewViewModel>> GetReviewsByCustomerIdAsync(int customerId);
        Task<List<ReviewViewModel>> GetRoomReviewsAsync(int roomId);
    }
}
