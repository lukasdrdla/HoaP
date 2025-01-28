using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Review;

namespace HoaP.Application.Services
{
    public class ReviewService
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task DeleteReviewAsync(int id)
        {
            await _reviewRepository.DeleteReviewAsync(id);
        }

        public async Task<List<ReviewViewModel>> GetReviewsAsync()
        {
            return await _reviewRepository.GetReviewsAsync();
        }

        public async Task<ReviewViewModel> GetReviewByIdAsync(int id)
        {
            return await _reviewRepository.GetReviewByIdAsync(id);
        }

        public async Task CreateReviewAsync(ReviewViewModel review)
        {
            await _reviewRepository.CreateReviewAsync(review);
        }

        public async Task UpdateReviewAsync(ReviewViewModel review)
        {
            await _reviewRepository.UpdateReviewAsync(review);
        }

        public async Task<List<ReviewViewModel>> GetReviewsByCustomerIdAsync(int customerId)
        {
            return await _reviewRepository.GetReviewsByCustomerIdAsync(customerId);
        }

        public async Task<List<ReviewViewModel>> GetRoomReviewsAsync(int roomId)
        {
            return await _reviewRepository.GetRoomReviewsAsync(roomId);
        }



    }
}
