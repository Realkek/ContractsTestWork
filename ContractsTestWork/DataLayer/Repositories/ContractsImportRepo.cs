using ContractsTestWork.DataLayer.Repositories.Interfaces;
using ContractsTestWork.Models;
using ContractsTestWork.Models.Entities;

namespace ContractsTestWork.DataLayer.Repositories;

public class ContractsImportRepo : IContractImportRepo
{
    private readonly ContractsDbContext _context;

    public ContractsImportRepo(ContractsDbContext contractsDbContext)
    {
        _context = contractsDbContext;
    }

    public async Task Add(Contract item)
    {
        await _context.Contracts.AddAsync(item);
        await _context.SaveChangesAsync();
    }

    public async Task Add(ContractStage item)
    {
        await _context.Stages.AddAsync(item);
        await _context.SaveChangesAsync();
    }
}