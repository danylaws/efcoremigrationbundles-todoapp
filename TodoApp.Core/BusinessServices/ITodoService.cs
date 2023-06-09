using TodoApp.Domain.Entities;

namespace TodoApp.Core.BusinessServices
{
    public interface ITodoService
    {
        Task AddAsync(Todo todo);

        Task<IEnumerable<Todo>> GetAllAsync();
    }
}