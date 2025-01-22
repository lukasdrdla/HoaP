using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly ApplicationDbContext _context;
        public ReviewRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task CreateReviewAsync(Review review)
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

        public async Task<Review> GetReviewByIdAsync(int id)
        {
            var review = await _context.Reviews
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .FirstOrDefaultAsync(r => r.Id == id);

            return review;
        }

        public async Task<List<Review>> GetReviewsAsync()
        {
            var reviews = await _context.Reviews
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .ToListAsync();

            return reviews;
        }

        public async Task<List<Review>> GetReviewsByCustomerIdAsync(int customerId)
        {
            var reviews = await _context.Reviews
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .Where(r => r.CustomerId == customerId)
                .ToListAsync();

            return reviews;
        }

        public async Task<List<Review>> GetRoomReviewsAsync(int roomId)
        {
            var reviews = await _context.Reviews
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .Where(r => r.RoomId == roomId)
                .ToListAsync();
            return reviews;
        }

        public async Task UpdateReviewAsync(Review review)
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
