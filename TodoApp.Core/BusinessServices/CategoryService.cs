using TodoApp.Data.Repositories;
using TodoApp.Domain.Entities;

namespace TodoApp.Core.BusinessServices
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repo;

        public CategoryService(ICategoryRepository repo)
        {
            _repo = repo;
        }

        public async Task AddAsync(Category category)
        {
            category.Id = Guid.NewGuid().ToString();
            await _repo.AddAsync(category);
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            IEnumerable<Category> all = await _repo.GetAllAsync();
            return all;
        }
    }
}