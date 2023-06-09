using TodoApp.Domain.Entities;

namespace TodoApp.Core.BusinessServices
{
    public interface ICategoryService
    {
        Task AddAsync(Category category);

        Task<IEnumerable<Category>> GetAllAsync();
    }
}