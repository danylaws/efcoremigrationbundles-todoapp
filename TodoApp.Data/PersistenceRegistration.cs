using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TodoApp.Data
{
    public static class PersistenceRegistration
    {
        public static IServiceCollection RegisterDatabase(
        this IServiceCollection services,
        IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DbConnection");

            services.AddDbContext<TodoAppDbContext>(
            dbContextOptions => dbContextOptions.UseSqlite(connectionString));

            return services;
        }
    }
}