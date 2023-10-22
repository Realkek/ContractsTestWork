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
    [Route("GetContracts")]
    public async Task<IActionResult> GetContracts()
    {
        // Здесь необходимо реализовать метод для получения списка договоров в формате JSON.
        // Используйте Entity Framework для извлечения данных из базы данных.
        var contracts = await _contractsService.GetContracts();
        var jsonContracts = JsonConvert.SerializeObject(contracts);
        return Json(jsonContracts);
    }

    [HttpGet]
    [Route("GetContractStages")]
    public IActionResult GetContractStages(int contractId)
    {
        // Здесь необходимо реализовать метод для получения списка этапов договора в формате JSON по выбранному договору.
        // Используйте Entity Framework для извлечения данных из базы данных.
        return Json(""); /* Список договоров в формате JSON */
    }
}