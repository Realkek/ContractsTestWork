using ContractsTestWork.Models.Entities;

namespace ContractsTestWork.DataLayer.Repositories.Interfaces;

public interface IContractImportRepo : IRepositoryWrite<Contract>, IRepositoryWrite<ContractStage>
{
    
}