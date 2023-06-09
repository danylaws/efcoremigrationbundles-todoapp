using Microsoft.EntityFrameworkCore;
using TodoApp.Domain.Entities;

namespace TodoApp.Data
{
    public class TodoAppDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Category> Categories { get; set; }

        public TodoAppDbContext(DbContextOptions<TodoAppDbContext> options)
          : base(options)
        {
        }
    }
}