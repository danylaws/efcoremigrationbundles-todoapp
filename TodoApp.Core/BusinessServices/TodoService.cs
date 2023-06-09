using TodoApp.Data.Repositories;
using TodoApp.Domain.Entities;

namespace TodoApp.Core.BusinessServices
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _repo;

        public TodoService(ITodoRepository repo) => this._repo = repo;

        public async Task AddAsync(Todo todo)
        {
            todo.Id = Guid.NewGuid().ToString();
            todo.CreatedAt = DateTime.Now;
            await this._repo.AddAsync(todo);
        }

        public async Task<IEnumerable<Todo>> GetAllAsync()
        {
            IEnumerable<Todo> all = await this._repo.GetAllAsync();
            return all;
        }
    }
}