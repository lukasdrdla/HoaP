using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Review;
using HoaP.Domain.Entities;

namespace HoaP.Application.Services
{
    public class ReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IMapper _mapper;

        public ReviewService(IReviewRepository reviewRepository, IMapper mapper)
        {
            _reviewRepository = reviewRepository;
            _mapper = mapper;
        }

        public async Task DeleteReviewAsync(int id)
        {
            await _reviewRepository.DeleteReviewAsync(id);
        }

        public async Task<List<ReviewViewModel>> GetReviewsAsync()
        {
            var entities = await _reviewRepository.GetReviewsAsync();
            return _mapper.Map<List<ReviewViewModel>>(entities);
        }

        public async Task<ReviewViewModel> GetReviewByIdAsync(int id)
        {
            var entity = await _reviewRepository.GetReviewByIdAsync(id);
            return _mapper.Map<ReviewViewModel>(entity);
        }

        public async Task CreateReviewAsync(ReviewFormViewModel review)
        {
            var entity = _mapper.Map<Review>(review);
            await _reviewRepository.CreateReviewAsync(entity);
        }

        public async Task UpdateReviewAsync(ReviewFormViewModel review)
        {
            var entity = _mapper.Map<Review>(review);
            await _reviewRepository.UpdateReviewAsync(entity);
        }

        public async Task<List<ReviewViewModel>> GetReviewsByCustomerIdAsync(int customerId)
        {
            var entities = await _reviewRepository.GetReviewsByCustomerIdAsync(customerId);
            return _mapper.Map<List<ReviewViewModel>>(entities);
        }

        public async Task<List<ReviewViewModel>> GetRoomReviewsAsync(int roomId)
        {
            var entities = await _reviewRepository.GetRoomReviewsAsync(roomId);
            return _mapper.Map<List<ReviewViewModel>>(entities);
        }
    }
}
