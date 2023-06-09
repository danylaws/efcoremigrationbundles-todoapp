using Microsoft.Extensions.DependencyInjection;
using TodoApp.Core.BusinessServices;
using TodoApp.Data.Repositories;

namespace TodoApp.Core
{
    public static class DependenciesRegistration
    {
        public static IServiceCollection RegisterBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ITodoRepository, TodoRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ITodoService, TodoService>();

            return services;
        }
    }
}