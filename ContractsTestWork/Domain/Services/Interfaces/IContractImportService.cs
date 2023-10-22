using Microsoft.AspNetCore.Mvc;

namespace ContractsTestWork.Domain.Services.Interfaces;

public interface IContractImportService
{
    Task<IActionResult> ImportContracts(IFormFile? file);
}