using Microsoft.EntityFrameworkCore;
using TodoApp.Domain.Entities;

namespace TodoApp.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly TodoAppDbContext _context;

        public CategoryRepository(TodoAppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}