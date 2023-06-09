using TodoApp.Domain.Entities;

namespace TodoApp.Data.Repositories
{
    public interface ICategoryRepository
    {
        Task AddAsync(Category category);

        Task<IEnumerable<Category>> GetAllAsync();
    }
}