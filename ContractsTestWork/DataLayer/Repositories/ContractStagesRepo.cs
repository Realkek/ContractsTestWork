using ContractsTestWork.DataLayer.Repositories.Interfaces;
using ContractsTestWork.Models;
using ContractsTestWork.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContractsTestWork.DataLayer.Repositories;

public class ContractStagesRepo : IContractStagesRepo
{
    private readonly ContractsDbContext _context;

    public ContractStagesRepo(ContractsDbContext contractsDbContext)
    {
        _context = contractsDbContext;
    }

    public async Task<IEnumerable<ContractStage>> GetContractStages(int contractId)
    {
        var stages = await _context.Stages
            .Where(s => s.ContractId == contractId)
            .ToListAsync();
        return stages;
    }
}