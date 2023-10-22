using ContractsTestWork.Models.Entities;

namespace ContractsTestWork.DataLayer.Repositories.Interfaces;

public interface IContractStagesRepo 
{
     Task<IEnumerable<ContractStage>>GetContractStages (int contractId);
}