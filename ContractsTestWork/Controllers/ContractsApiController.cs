using Microsoft.AspNetCore.Mvc;

namespace ContractsTestWork.Controllers;

[Route("api/Contracts")]
public class ContractsApiController : Controller
{
    [HttpGet]
    [Route("GetContracts")]
    public IActionResult GetContracts()
    {
        // Здесь необходимо реализовать метод для получения списка договоров в формате JSON.
        // Используйте Entity Framework для извлечения данных из базы данных.
        return Json(""); /* Список договоров в формате JSON */
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