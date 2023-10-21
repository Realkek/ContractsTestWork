using ContractsTestWork.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContractsTestWork.DataLayer.EF.Configurations;

public class ContractsStagesConfiguration : IEntityTypeConfiguration<ContractStage>
{
    public void Configure(EntityTypeBuilder<ContractStage> builder)
    {
        builder.ToTable(nameof(ContractStage), "dbo");
        builder.HasOne(contractStage => contractStage.Contract)
            .WithMany(contract => contract.Stages)
            .HasForeignKey(contractStage => contractStage.ContractId);
    }
}