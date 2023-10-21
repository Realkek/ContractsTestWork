using ContractsTestWork.DataLayer.EF.Configurations;
using ContractsTestWork.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContractsTestWork.Models;

public class ContractsDbContext : DbContext
{
    public DbSet<Contract> Contracts { get; set; }
    public DbSet<ContractStage> Stages { get; set; }

    public ContractsDbContext(DbContextOptions<ContractsDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ContractsConfiguration());
        modelBuilder.ApplyConfiguration(new ContractsStagesConfiguration());
    }
}