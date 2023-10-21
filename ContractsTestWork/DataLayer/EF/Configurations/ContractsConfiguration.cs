using ContractsTestWork.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContractsTestWork.DataLayer.EF.Configurations;

public class ContractsConfiguration : IEntityTypeConfiguration<Contract>
{
    public void Configure(EntityTypeBuilder<Contract> builder)
    {
        builder.ToTable(nameof(Contract), "dbo");
    }
}