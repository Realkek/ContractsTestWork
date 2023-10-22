using ContractsTestWork.DataLayer.Repositories.Interfaces;
using ContractsTestWork.Domain.Services.Interfaces;
using ContractsTestWork.Models.Entities;

namespace ContractsTestWork.Domain.Services;

public class ContractService : IContractsService
{
    private readonly IContractsRepo _contractsRepo;

    public ContractService(IContractsRepo contractsRepo)
    {
        _contractsRepo = contractsRepo;
    }

    public async Task<List<Contract>> GetContracts()
    {
        var contracts = await _contractsRepo.GetItems();
        return contracts.ToList();
    }
}