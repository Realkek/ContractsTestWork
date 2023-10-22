using ContractsTestWork.DataLayer.Repositories;
using ContractsTestWork.DataLayer.Repositories.Interfaces;
using ContractsTestWork.Domain.Services;
using ContractsTestWork.Domain.Services.Interfaces;
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

    public static void ConfigureDomainServices(this IServiceCollection services)
    {
        services.AddScoped<IContractsService, ContractService>();
    }

    public static void ConfigureRepositories(this IServiceCollection services)
    {
        services.AddScoped<IContractsRepo, ContractsRepo>();
    }
}