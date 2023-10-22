using ContractsTestWork.DataLayer.Repositories.Interfaces;
using ContractsTestWork.Domain.Services.Interfaces;
using ContractsTestWork.Models.Entities;

namespace ContractsTestWork.Domain.Services;

public class ContractService : IContractsService
{
    private readonly IContractsRepo _contractsRepo;
    private readonly IContractStagesRepo _contractStagesRepo;

    public ContractService(IContractsRepo contractsRepo, IContractStagesRepo contractStagesRepo)
    {
        _contractsRepo = contractsRepo;
        _contractStagesRepo = contractStagesRepo;
    }

    public async Task<IEnumerable<Contract>> GetContracts()
    {
        var contracts = await _contractsRepo.GetItems();
        return contracts;
    }

    public async Task<IEnumerable<ContractStage>> GetContractStages(int contractId)
    {
        var contractStages = await _contractStagesRepo.GetContractStages(contractId);
        return contractStages;
    }
}