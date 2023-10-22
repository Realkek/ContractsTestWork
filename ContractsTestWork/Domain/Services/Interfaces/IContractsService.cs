using ContractsTestWork.Models.Entities;

namespace ContractsTestWork.Domain.Services.Interfaces;

public interface IContractsService
{
    Task<IEnumerable<Contract>> GetContracts();
    Task<IEnumerable<ContractStage>> GetContractStages(int contractId);
}