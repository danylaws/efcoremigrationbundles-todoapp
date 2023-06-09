using Microsoft.EntityFrameworkCore;
using TodoApp.Domain.Entities;

namespace TodoApp.Data.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoAppDbContext _context;

        public TodoRepository(TodoAppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Todo todo)
        {
            await _context.Todos.AddAsync(todo);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Todo>> GetAllAsync()
        {
            return await _context.Todos.Include(c => c.Category).ToListAsync();
        }
    }
}