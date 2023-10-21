using ContractsTestWork.Models;
using Microsoft.EntityFrameworkCore;

namespace ContractsTestWork.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static void ConfigureDbContext(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ContractsDbContext>(options =>
        {
            options.UseSqlServer(
                configuration.GetConnectionString("DbConnectionString"));
        });
    }
}