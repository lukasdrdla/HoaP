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

        public async Task CreateReviewAsync(Review review)
        {
            await _context.Reviews.AddAsync(review);
            await _context.SaveChangesAsync();
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

        public async Task<Review?> GetReviewByIdAsync(int id)
        {
            return await _context.Reviews
                .AsNoTracking()
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<List<Review>> GetReviewsAsync()
        {
            return await _context.Reviews
                .AsNoTracking()
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .ToListAsync();
        }

        public async Task<List<Review>> GetReviewsByCustomerIdAsync(int customerId)
        {
            return await _context.Reviews
                .AsNoTracking()
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .Where(r => r.CustomerId == customerId)
                .ToListAsync();
        }

        public async Task<List<Review>> GetRoomReviewsAsync(int roomId)
        {
            return await _context.Reviews
                .AsNoTracking()
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .Where(r => r.RoomId == roomId)
                .ToListAsync();
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
