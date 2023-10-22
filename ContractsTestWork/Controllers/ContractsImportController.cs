using Microsoft.AspNetCore.Mvc;

namespace ContractsTestWork.Controllers;

[Route("api/Import")]
public class ContractsImportController : Controller
{
    [HttpPost]
    [Route("UploadFile")]
    public async Task<IActionResult> UploadFile(IFormFile file)
    {
        // Здесь необходимо реализовать обработку загруженного файла Excel и добавление данных в базу данных.
        // Можно использовать библиотеки для работы с Excel, такие как EPPlus или ClosedXML.
        return Ok("File uploaded and data added to the database.");
    }
}