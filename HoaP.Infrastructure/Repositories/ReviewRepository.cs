using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Review;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ReviewRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task CreateReviewAsync(ReviewViewModel review)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteReviewAsync(int id)
        {
            var existingReview = await _context.Reviews.FindAsync(id);
            if (existingReview != null)
            {
                _context.Reviews.Remove(existingReview);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<ReviewViewModel> GetReviewByIdAsync(int id)
        {
            var review = await _context.Reviews
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .FirstOrDefaultAsync(r => r.Id == id);

            return _mapper.Map<ReviewViewModel>(review);
        }

        public async Task<List<ReviewViewModel>> GetReviewsAsync()
        {
            var reviews = await _context.Reviews
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .ToListAsync();

            return _mapper.Map<List<ReviewViewModel>>(reviews);
        }

        public async Task<List<ReviewViewModel>> GetReviewsByCustomerIdAsync(int customerId)
        {
            var reviews = await _context.Reviews
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .Where(r => r.CustomerId == customerId)
                .ToListAsync();

            return _mapper.Map<List<ReviewViewModel>>(reviews);
        }

        public async Task<List<ReviewViewModel>> GetRoomReviewsAsync(int roomId)
        {
            var reviews = await _context.Reviews
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .Where(r => r.RoomId == roomId)
                .ToListAsync();
            return _mapper.Map<List<ReviewViewModel>>(reviews);
        }

        public async Task UpdateReviewAsync(ReviewViewModel review)
        {
            var existingReview = await _context.Reviews.FindAsync(review.Id);

            if (existingReview != null)
            {
                existingReview.Rating = review.Rating;
                existingReview.Comment = review.Comment;
                await _context.SaveChangesAsync();
            }

        }
    }
}
