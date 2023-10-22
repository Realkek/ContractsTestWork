using ContractsTestWork.Models.Entities;

namespace ContractsTestWork.Domain.Services.Interfaces;

public interface IContractsService
{
    Task<List<Contract>> GetContracts();
}