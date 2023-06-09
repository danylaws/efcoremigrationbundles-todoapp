using TodoApp.Domain.Entities;

namespace TodoApp.Data.Repositories
{
    public interface ITodoRepository
    {
        Task AddAsync(Todo todo);

        Task<IEnumerable<Todo>> GetAllAsync();
    }
}