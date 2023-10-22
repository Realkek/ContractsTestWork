using ContractsTestWork.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ContractsTestWork.Controllers;

[Route("api/Contracts")]
public class ContractsApiController : Controller
{
    private readonly IContractsService _contractsService;

    public ContractsApiController(IContractsService contractsService)
    {
        _contractsService = contractsService;
    }

    [HttpGet]
    [Route(nameof(GetContracts))]
    public async Task<IActionResult> GetContracts()
    {
        var contracts = await _contractsService.GetContracts();
        var jsonContracts = JsonConvert.SerializeObject(contracts);
        return Json(jsonContracts);
    }

    [HttpGet]
    [Route(nameof(GetContractStages))]
    public async Task<IActionResult> GetContractStages(int contractId)
    {
        var stages = await _contractsService.GetContractStages(contractId);
        var jsonStages = JsonConvert.SerializeObject(stages);
        return Json(jsonStages);
    }
}