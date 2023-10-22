using ContractsTestWork.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ContractsTestWork.Controllers;

[Route("api/Import")]
public class ContractsImportController : Controller
{
    private readonly IContractImportService _contractsImportService;

    public ContractsImportController(IContractImportService contractsImportService)
    {
        _contractsImportService = contractsImportService;
    }

    [HttpPost]
    [Route(nameof(UploadFile))]
    public async Task<IActionResult> UploadFile(IFormFile file)
    {
        await _contractsImportService.ImportContracts(file);
        return new OkResult();
    }
}