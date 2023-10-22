using ContractsTestWork.DataLayer.Repositories.Interfaces;
using ContractsTestWork.Models;
using ContractsTestWork.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContractsTestWork.DataLayer.Repositories;

public class ContractsRepo : IContractsRepo
{
    private readonly ContractsDbContext _context;

    public ContractsRepo(ContractsDbContext contractsDbContext)
    {
        _context = contractsDbContext;
    }
    
    public Task<Contract> GetItem(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Contract>> GetItems()
    {
        var result = await _context.Contracts.ToListAsync();

        return result;
    }
}